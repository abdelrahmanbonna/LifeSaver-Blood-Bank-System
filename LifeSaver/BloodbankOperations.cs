using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace LifeSaver
{
    class BloodbankOperations
    {
        public static BloodBank bank = new BloodBank();
        public static bool Login(string email, string password)
        {
            string[] cols = new string[] { "bb_email", "bb_password" ,"bb_deleted","bb_name"};
            string q = "select * from BloodBank where bb_email='" + email + "' and bb_password='" + password + "'";
            string[] results = DatabaseHandler.getvarfromDB(q, cols);
            if (results == null||results[2]=="1")
                return false;
            bank.Email = email;
            bank.Name = results[3];
            return true;
        }

        public static void FrogetPass(string _email)
        { 

            string pattern = @"^([0-9a-zA-Z]" + //Start with a digit or alphabetical
            @"([\+\-_\.][0-9a-zA-Z]+)*" + // No continuous or ending +-_. chars in email
            @")+" +
            @"@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$";

            if (_email != string.Empty && Regex.IsMatch(_email, pattern))
            {
                string password_col = "bb_password";
                string Quary = "select * from Bloodbank where bb_email='" + _email + "'";
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

        //functions to access the no_of_blood_packs array ((they have to be added in the data base))
        public static bool add_blood_type(blood_types b,string bloodbankname,DateTime exp_date )
        {
            /* update:::no need to the commented part
            int i = (int)b;                             //casting the blood type to be an integer equals to its index in the array
            no_of_blood_packs[i]++;                     //incrementing number of this type in the array
            */
            string cols = "bb_id";
            string q = "select * from BloodBanks where bb_name='" + bloodbankname + "'";
            string result = DatabaseHandler.getvarfromDB(q, cols);       //get th id of the bloodbank name we want to add in
            q = "insert into BloodPacks values (" + exp_date + "," + b + "," + result + ")";
            return DatabaseHandler.insertdatatodatabase(q);
        }
        //
        public static bool remove_blood_type(blood_types b, string bloodbankname)      //it takes argument of blood_types enum parameter
        {
            /* update:::no need to the commented part
            int i = (int)b;                             //casting the blood type to be an integer equals to its index in the array
            //must first check the data base if it doesn't equal zero
            if (no_of_blood_packs[i] > 0)
            {
                no_of_blood_packs[i]--;                     //decrementing number of this type in the array
            }
            */
            string cols = "bb_id";
            string q = "select * from BloodBanks where bb_name='" + bloodbankname + "'";
            string result = DatabaseHandler.getvarfromDB(q, cols);       //get th id of the bloodbank name we want to remove from
            q = "delete from BloodPacks where bpack_bloodtype='" + b + "'and bpack_bank='" + result + "'";
            return DatabaseHandler.insertdatatodatabase(q);
        }


        public void Request_Blood(string _username, string _useremail, string _bloodBankName, string _PageType, int amount)
        {
            string[] email_col = new string[2] { "bb_email", "bb_mobile" };
            string Quary = "select * from Bloodbank where bb_name='" + _bloodBankName + "'";
            string[] Bloodbankinfo = DatabaseHandler.getvarfromDB(Quary, email_col);
            if (Bloodbankinfo[0] != string.Empty)
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential("life.saver.admon@gmail.com", "12345.life");
                client.EnableSsl = true;
                MailMessage mesaage = new MailMessage("life.saver.admon@gmail.com", Bloodbankinfo[0], string.Format("{0} Emergency situation", _username), string.Format("The {0} in life saver services system needs {1} pages from type {2}." +
                    "Please contact him on {3} or ", _username, amount, _PageType, _useremail, Bloodbankinfo[1]));
                mesaage.IsBodyHtml = false;
                client.Send(mesaage);
                MessageBox.Show("They will contact you shortly by mail or mobile!");
            }
        }


    }
}
