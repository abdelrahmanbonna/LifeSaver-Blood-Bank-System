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
        public byte[] picture { set; get; }
        public override void Login(string _email, string _password) { throw new NotImplementedException(); }
        public override void ProfileEdit(object _any) { throw new NotImplementedException(); }
        public override void FrogetPass(string _email) 
        {

            string pattern = @"^([0-9a-zA-Z]" + //Start with a digit or alphabetical
            @"([\+\-_\.][0-9a-zA-Z]+)*" + // No continuous or ending +-_. chars in email
            @")+" +
            @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";

            if (_email != string.Empty && Regex.IsMatch(_email, pattern))
            {
                string password_col = "users_password";
                string Quary = "select * from Users where users_email='" + _email + "'";
                string Password = DatabaseHandler.getvarfromDB(Quary, password_col);

                if (Password != string.Empty)
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.Credentials = new NetworkCredential("life.saver.admon@gmail.com", "12345.life");
                    client.EnableSsl = true;
                    MailMessage mesaage = new MailMessage("life.saver.admon@gmail.com", _email, "Password reset", string.Format("You password is {0}", Password));
                    mesaage.IsBodyHtml = false;
                    client.Send(mesaage);
                    MessageBox.Show("Review your mailbox");
                }
            }
            else
                MessageBox.Show("Please Enter Correct Email");
        }
        public override void DeletAccount(string _email, string _password) { throw new NotImplementedException(); }
        public override void Request_Blood(string _username, string _useremail, string _bloodBankName, string _PageType, int amount)
        {
            string email_col = "bb_email";
            string Quary = "select * from Bloodbank where bb_name='" + _bloodBankName + "'";
            string BloodbankEmail = DatabaseHandler.getvarfromDB(Quary, email_col);
            
            if (BloodbankEmail != string.Empty)
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential("life.saver.admon@gmail.com", "12345.life");
                client.EnableSsl = true;
                MailMessage mesaage = new MailMessage("life.saver.admon@gmail.com", BloodbankEmail, "Blood Pages Request", string.Format("{0} is an user in life saver services system and he/she needs {1} pages from type {2}." +
                    "Please contact him on {3}", _useremail, amount, _PageType, _useremail));
                mesaage.IsBodyHtml = false;
                client.Send(mesaage);
                MessageBox.Show("They will contact you shortly by mail!");
            }
        }

    }
}
 