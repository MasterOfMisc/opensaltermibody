using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenMiBody.BusinessLogic
{
    public class MiBodyData
    {
        public List<byte> _rawData = new List<byte>();

        public int _userSlot = -1;
        public DateTime _dateTime = DateTime.Now;
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
        public DateTime _dateTime = DateTime.Now;
        public int _age;
        public int _heightInCm = 0;

        public List<MiBodyData> miBodyDataList = new List<MiBodyData>();
    }

    // This is the daddy class! - Has a list of users which contain there own data! Nice.
    public class MiBodySystem
    {
        public List<MiBodyUser> miBodyUserList = new List<MiBodyUser>();

    }
}
