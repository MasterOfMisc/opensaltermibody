using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMiBody.BusinessLogic
{
    public enum Gender { Male, Female };

    public class MiBodyData
    {
        public List<byte> _rawData = new List<byte>();

        public int _userSlot = -1;
        public DateTime _dateTime;

        public Gender _gender;

        public int _age;
        public int _heightInCm = 0;
        public double _weight = 0;
        public double _bodyFat = 0;
        public int _visceralFat = 0;
        public double _bmi = 0;
        public double _bmr = 0;
        public double _muscleMass = 0;
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

        public void PopulateUserData()
        {
            foreach (MiBodyUser user in miBodyUserList)
            {
                foreach (MiBodyData bodyData in user.miBodyDataList)
                {
                    // Step 01: Get Year
                    int year = bodyData._rawData[0] << 8;
                    year += bodyData._rawData[1];

                    if (year == 0)
                        continue; // There is no data here! Move along...

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
                    bodyData._weight = bodyData._rawData[8];

                    // Step 08: Get weight
                    int tmp1 = bodyData._rawData[10];
                    int tmp2 = bodyData._rawData[11];

                    // Step 9: Get body fat
                    tmp1 = bodyData._rawData[12];
                    tmp2 = bodyData._rawData[13];

                    // Step 10: Get Muscle Mass
                    tmp1 = bodyData._rawData[15];
                    tmp2 = bodyData._rawData[16];

                    // Step 11: Get Visceral Fat
                    bodyData._visceralFat = bodyData._rawData[17];
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
