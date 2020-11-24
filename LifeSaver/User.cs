using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LifeSaver
{
   public class User : Person
    {
        public DateTime birthdate { set; get; }
        public string HealthCond { set; get; }
        public blood_types BloodType { set; get; }
        public string mobileNo { set; get; }
        public string pictureLoc { set; get; }
      
    }
}
 