using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OpenMiBody.BusinessLogic
{
    public enum Gender { Male, Female };

    public class MiBodyData
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
    }

    public class MiBodyUser
    {
        public int _userSlot = -1;
        //public DateTime _dateTime = DateTime.Now;
        //public int _age;
        //public int _heightInCm = 0;

        public List<MiBodyData> miBodyDataList = new List<MiBodyData>();
    }

    // This is the daddy class! - Has a list of users which contain there own data! Nice.
    public class MiBodySystem
    {
        public List<MiBodyUser> miBodyUserList = new List<MiBodyUser>();

        public double CalculateBMI(MiBodyData bd)
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

        public double CalculateBMR(MiBodyData bd)
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
        public void FillInUserData()
        {
            foreach (MiBodyUser user in miBodyUserList)
            {
                foreach (MiBodyData bodyData in user.miBodyDataList)
                {
                    bodyData._userSlot = user._userSlot;

                    // Step 01: Get Year
                    int year = bodyData._rawData[0] << 8;
                    year += bodyData._rawData[1];

                    if (year == 0)
                        continue; // There is no data here! Move along...

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
                }
            }
        }
    }

    public class Utilities
    {
        public static double ConvertWeightKGToPounds( double value )
        {
            return value * 2.20462262;
        }

        public static string ConvertWeightKGToStonePounds(double value)
        {
            // http://msdn.microsoft.com/en-us/library/yda5c8dx.aspx
            int remainder;
            //int quotient = Math.DivRem(Convert.ToInt32(value), 0.157473044, out remainder);

            return "";
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
