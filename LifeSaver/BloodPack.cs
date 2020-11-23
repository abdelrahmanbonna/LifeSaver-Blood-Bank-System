using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSaver
{
    class BloodPack
    {
        private DateTime Exp_Date;
        private blood_types Blood_type;
        private int Bloodbank_ID;



        public DateTime Expdate
        {
            get { return Exp_Date; }
            set { Exp_Date = value; }
        }


        public blood_types Bloodtype
        {
            get { return Blood_type; }
            set { Blood_type = value; }
        }

        public int BloodbankID
        {
            get { return Bloodbank_ID; }
            set { Bloodbank_ID = value; }
        }
    }
}
