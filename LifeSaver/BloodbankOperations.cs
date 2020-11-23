using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
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

            string password_col = "bb_password";
            string Quary = "select * from Bloodbank where bb_email='" + _email + "'";
            string Password = DatabaseHandler.getvarfromDB(Quary, password_col);
            if (Password != "Error Data not found")
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


    }
}
