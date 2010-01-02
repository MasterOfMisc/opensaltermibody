﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            double tmp = bd._heightInCM * bd._heightInCM;

            // convert centimetres to metres
            tmp = tmp * 0.01;

            double bmi = bd._weightInKG / tmp;
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
                    int startbit = 8;
                    int bitcount = 1;
                    int gender = Utilities.GetBits(bodyData._rawData[7], startbit, bitcount);
                    if (gender == 0)
                        bodyData._gender = Gender.Female;
                    else
                        bodyData._gender = Gender.Male;

                    // Step 06: Get Age
                    startbit = 7;
                    bitcount = 7;
                    bodyData._age = Utilities.GetBits(bodyData._rawData[7], startbit, bitcount);

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

        //DateTime SecondsFromWords(int word1, int word2)
        //{
        //    //int word1 = 30868; // 0111100010010100 (16 bits)
        //    //int word2 = 18887; // 0100100111000111 (16 bits)

        //    // Step 01: Shift bits up 16 places

        //    int result = word2 << 16;

        //    result += word1;

        //    return UnixDate.ConvertFromUnixTimestamp(result);
        //}
    }
}
