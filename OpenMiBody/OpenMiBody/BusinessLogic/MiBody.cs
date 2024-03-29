﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace OpenMiBody.BusinessLogic
{
    public enum Gender { Male, Female };

    public enum Weight { Kilogrames, PoundsLB, Stone }

    public enum HeightMeasure { Centimetres, Inches }
    
    public class MiBodyData // Weight Reading from scales
    {
        public bool _valid = false;
        public List<byte> _rawData = new List<byte>();

        public int _userSlot = -1;
        public DateTime _dateTime;

        public Gender _gender;

        public int _age;
        public int _heightInCM = 0;

        public string _weightInKGStr = "";
        public double _weightInKG = 0;

        public string _bodyFatStr = "";
        public double _bodyFat = 0;

        public string _muscleMassStr = "";
        public double _muscleMass = 0;

        public int _visceralFat = 0;
        public double _bmi = 0;
        public double _bmr = 0;
        public double _bodyWater = 0;

        string _userComment;
    }

    public class MiBodyUser
    {
        public int _userSlot = -1;

        public string _name;
        public double _targetWeightInKG = 0;

        public List<MiBodyData> miBodyDataList = new List<MiBodyData>();
    }


    class MiBodySystemSerialization
    {
        /// <summary>
        /// To convert a Byte Array of Unicode values (UTF-8 encoded) to a complete String.
        /// </summary>
        /// <param name="characters">Unicode Byte Array to be converted to String</param>
        /// <returns>String converted from Unicode Byte Array</returns>
        static private String UTF8ByteArrayToString(Byte[] characters)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            String constructedString = encoding.GetString(characters);
            return (constructedString);
        }

        static private String ASCIIByteArrayToString(Byte[] characters)
        {
            //UTF8Encoding encoding = new UTF8Encoding();
            //UnicodeEncoding encoding = new UnicodeEncoding();  

            ASCIIEncoding encoding = new ASCIIEncoding();
            String constructedString = encoding.GetString(characters);
            return (constructedString);
        }

        /// <summary>
        /// Converts the String to UTF8 Byte array and is used in De serialization
        /// </summary>
        /// <param name="pXmlString"></param>
        /// <returns></returns>
        static private Byte[] StringToUTF8ByteArray(String pXmlString)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(pXmlString);
            return byteArray;
        }


        static public void WriteObjectToXMLFile(Object pObject, string fileName)
        {
            string xmlString = SerializeObject(pObject);

            if (xmlString == null)
                return;

            // Now write this string out to the file
            FileInfo file = new FileInfo(fileName);
            using (StreamWriter text = file.CreateText())
            {
                text.Write(xmlString);
            }
        }

        static public string WriteObjectToXMLString(Object pObject)
        {
            return SerializeObject(pObject);
        }

        static public string ReadXMLFileIntoString(string inputFileName)
        {
            StringBuilder fileContents = new StringBuilder();
            using (StreamReader re = File.OpenText(inputFileName))
            {
                string line = null;
                while ((line = re.ReadLine()) != null)
                {
                    fileContents.Append(line);
                }
            }

            return fileContents.ToString();
        }

        static public object ReadXMLFileToObject(string inputFileName)
        {
            StringBuilder fileContents = new StringBuilder();
            using (StreamReader re = File.OpenText(inputFileName))
            {
                string line = null;
                while ((line = re.ReadLine()) != null)
                {
                    fileContents.Append(line);
                }
            }

            return DeserializeObject(fileContents.ToString());
        }

        static public object ReadXMLStringToObject(string inputFileName)
        {
            return DeserializeObject(inputFileName);
        }



        /// <summary>
        /// Method to convert a custom Object to XML string
        /// </summary>
        /// <param name="pObject">Object that is to be serialized to XML</param>
        /// <returns>XML string</returns>
        static public String SerializeObject(Object pObject)
        {
            try
            {
                String XmlizedString = null;
                MemoryStream memoryStream = new MemoryStream();
                XmlSerializer xs = new XmlSerializer(typeof(MiBodySystem));
                //XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.ASCII);

                xs.Serialize(xmlTextWriter, pObject);
                memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
                //XmlizedString = UTF8ByteArrayToString(memoryStream.ToArray());
                XmlizedString = ASCIIByteArrayToString(memoryStream.ToArray());
                return XmlizedString;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return null;
            }
        }

        /// <summary>
        /// Method to reconstruct an Object from XML string
        /// </summary>
        /// <param name="pXmlizedString"></param>
        /// <returns></returns>
        static public Object DeserializeObject(String pXmlizedString)
        {
            XmlSerializer xs = new XmlSerializer(typeof(MiBodySystem));
            MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(pXmlizedString));
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);

            return xs.Deserialize(memoryStream);
        }


    }

    // This is the daddy class! - Has a list of users which contain there own data! Nice.
    [XmlRoot(ElementName = "MiBodyUserData", IsNullable = false)]
    [Serializable]
    public class MiBodySystem
    {
        public List<MiBodyUser> miBodyUserList = new List<MiBodyUser>();
        
        internal double CalculateBodyWaterPerc(MiBodyData bd)
        {
            double muscleMass = bd._muscleMass * bd._weightInKG / 100;

            double fatMass = bd._bodyFat * bd._weightInKG / 100;

            double restOfFluids = bd._weightInKG - muscleMass - fatMass;

            double waterMass = muscleMass * 0.83 + restOfFluids * 0.62;

            double waterPerc = waterMass / bd._weightInKG * 100;

            return Math.Round(waterPerc, 1);
        }

        internal double CalculateBMI(MiBodyData bd)
        {
            // convert height from cm to metres
            double heightInMetres = bd._heightInCM * 0.01;

            double tmp = heightInMetres * heightInMetres;

            double bmi = bd._weightInKG / tmp;

            bmi = Math.Round(bmi, 1);
            return bmi;

//            1.6 x 1.6 = 2.56. BMI would be 65 divided by 2.56 = 25.39. 
            // calc taken from here: 
            // http://www.bbc.co.uk/health/healthy_living/your_weight/bmiimperial_index.shtml
        }

        internal double CalculateBMR(MiBodyData bd)
        {
            // calc taken from here: 
            // http://www.bmi-calculator.net/bmr-calculator/bmr-formula.php

            double BMR = 0;
            if ( bd._gender == Gender.Female )
            {
                // Women: BMR = 655 + ( 9.6 x weight in kilos ) + ( 1.8 x height in cm ) - ( 4.7 x age in years )
                BMR = 655 + ( 9.6 * bd._weightInKG ) + ( 1.8 * bd._heightInCM ) - ( 4.7 * bd._age );
            }
            else
            {
                // Men: BMR = 66 + ( 13.7 x weight in kilos ) + ( 5 x height in cm ) - ( 6.8 x age in years )
                BMR = 66 + (13.7 * bd._weightInKG) + (5 * bd._heightInCM) - (6.8 * bd._age);
            }

            return BMR;
        }

        internal MiBodyUser GetUser(int nUserNum)
        {
            foreach (MiBodyUser user in miBodyUserList)
            {
                if ( user._userSlot == nUserNum)
                    return user;
            }

            // Looks like this user was not found! Lets create a new user and pass it back!
            MiBodyUser newUser = new MiBodyUser();
            return newUser;
        }

        internal void AddUser(MiBodyUser newUser)
        {
            foreach (MiBodyUser user in miBodyUserList)
            {
                if (user._userSlot == newUser._userSlot)
                    return;
            }

            // Looks like this user was not found! Lets add it to the list!
            miBodyUserList.Add(newUser);
        }

        internal bool CheckDateTimeExists(DateTime dt, MiBodyUser user)
        {
            foreach (MiBodyData data in user.miBodyDataList)
            {
                if ( data._dateTime == dt)
                    return true;
            }

            return false;
        }

        internal DateTime DecodeDateTimeFromRawData(MiBodyData bodyData)
        {
            // Step 01: Get Year
            int year = bodyData._rawData[0] << 8;
            year += bodyData._rawData[1];

            // Step 02: Get Month
            int month = bodyData._rawData[2];

            // Step 03: Get Day
            int day = bodyData._rawData[3];

            // Step 04: Get Time 
            int hour = bodyData._rawData[4];
            int min = bodyData._rawData[5];
            int sec = bodyData._rawData[6];

            bodyData._dateTime = new DateTime(year, month, day, hour, min, sec);

            return bodyData._dateTime;
        }

        public void CalculateBodyData(MiBodyData bodyData)
        {
            // Step 01: Get Year
            int year = bodyData._rawData[0] << 8;
            year += bodyData._rawData[1];

            if (year == 0)
                return; // There is no data here! Move along...

            bodyData._valid = true;
            // Step 02: Get Month
            int month = bodyData._rawData[2];

            // Step 03: Get Day
            int day = bodyData._rawData[3];

            // Step 04: Get Time 
            int hour = bodyData._rawData[4];
            int min = bodyData._rawData[5];
            int sec = bodyData._rawData[6];

            bodyData._dateTime = new DateTime(year, month, day, hour, min, sec);

            // Step 05: Get Gender

            // convert rawData 7 to a bit array
            BitArray ageBits = new BitArray(BitConverter.GetBytes(bodyData._rawData[7]));

            // get bit 8 (zero index so is 7!)
            bool genderBit = ageBits.Get(7);

            if (genderBit == false)
                bodyData._gender = Gender.Female;
            else
                bodyData._gender = Gender.Male;

            //  Set gender bit (8) to zero so we can get the age!
            ageBits.Set(7, false);

            // Step 06: Get Age
            bodyData._age = Utilities.GetBitArrayValue(ageBits);

            // Step 07: Get height
            bodyData._heightInCM = bodyData._rawData[8];

            // Step 08: Get weight
            int tmp1 = bodyData._rawData[10];
            int tmp2 = bodyData._rawData[11];
            int result = tmp1 << 8;
            result += tmp2;
            bodyData._weightInKGStr = result.ToString();
            bodyData._weightInKGStr = bodyData._weightInKGStr.Insert(bodyData._weightInKGStr.Length - 1, ".");
            bodyData._weightInKG = Convert.ToDouble(bodyData._weightInKGStr);

            // Step 9: Get body fat
            tmp1 = bodyData._rawData[12];
            tmp2 = bodyData._rawData[13];
            result = tmp1 << 8;
            result += tmp2;
            bodyData._bodyFatStr = result.ToString();
            bodyData._bodyFatStr = bodyData._bodyFatStr.Insert(bodyData._bodyFatStr.Length - 1, ".");
            bodyData._bodyFat = Convert.ToDouble(bodyData._bodyFatStr);

            // Step 10: Get Muscle Mass
            tmp1 = bodyData._rawData[15];
            tmp2 = bodyData._rawData[16];
            result = tmp1 << 8;
            result += tmp2;
            bodyData._muscleMassStr = result.ToString();
            bodyData._muscleMassStr = bodyData._muscleMassStr.Insert(bodyData._muscleMassStr.Length - 1, ".");
            bodyData._muscleMass = Convert.ToDouble(bodyData._muscleMassStr);

            // Step 11: Get Visceral Fat
            bodyData._visceralFat = bodyData._rawData[17];

            // Step 12: Calc BMR
            bodyData._bmr = CalculateBMR(bodyData);

            // Step 13: Calc BMI
            bodyData._bmi = CalculateBMI(bodyData);

            bodyData._bodyWater = CalculateBodyWaterPerc(bodyData);
        }

        internal void FillInUserData()
        {
            foreach (MiBodyUser user in miBodyUserList)
            {
                foreach (MiBodyData bodyData in user.miBodyDataList)
                {
                    bodyData._userSlot = user._userSlot;

                    CalculateBodyData(bodyData);
                }
            }
        }
    }

    public class Utilities
    {
        public static double ConvertCMToInches(double value)
        {
            double cm = 0.393700787;
            double total;
            total = (value * cm); // Perform Calculation

            return Math.Round(total, 2);
        }

        public static double ConvertWeightKGToPounds( double value )
        {
            return value * 2.2;
        }

        public static string ConvertWeightKGToStonePounds(double kgWeight)
        {
            // http://help.wugnet.com/office/kg-stone-convertion-excel-ftopict1052299.html

            //int stone = Convert.ToInt32(2.2 * kgWeight / 14);

            double stone = Convert.ToDouble(kgWeight * 0.157473044418);

            string stoneStr = stone.ToString();

            int index = stoneStr.IndexOf(".");

            stoneStr = stoneStr.Substring(0, index);
            //int stone = Convert.ToInt32(kgWeight * 0.157473044418);

                        double pounds = (kgWeight * 0.157473044418 - (int)(kgWeight*0.157473044418))*14;

            pounds = Math.Round(pounds, 2);

            return string.Format("{0} Stone {1} Pound(s)", stoneStr, pounds);

        }
        public static byte GetBitArrayValue(BitArray bArray)
        {
            byte value = 0x00;

            for (byte x = 0; x < bArray.Count; x++)
            {
                value |= (byte)((bArray[x] == true) ? (0x01 << x) : 0x00);
            }

            return value;
        }

        public static byte LowByte(ushort word)
        {
            return (byte)word;
        }

        static public byte HighByte(ushort word)
        {
            return ((byte)(((ushort)(word) >> 8) & 0xFF));
        }


        static public ushort GetBits(byte value, int startbit, int bitcount)
        {
            ushort result;

            result = (byte)(value << (startbit - 1));

            result = (byte)(result >> (8 - bitcount));

            return result;
        }
    }
}
