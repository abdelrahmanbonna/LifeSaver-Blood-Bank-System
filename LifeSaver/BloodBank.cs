using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LifeSaver
{
    //This is the blood bank model

    public enum blood_types        //this is a temporary enum untill blood clase is made
    {
        A_pos, A_neg, B_pos, B_neg, AB_pos, AB_neg, O_pos, O_neg
    }
    public class BloodBank : Person             //inherits person class
    {
        public String mob_no { set; get; }                  //setter and getter for blood bank admin mobile number
        public String address { set; get; }                //setter and getter for blood bank address
        public int ID { set; get; }                        //setter and getter for blood bank ID     
        private int[] no_of_blood_packs = new int[8];      /*an array containing number of blood packs in each bank according to
                                                            * blood_types enum ====> i.e index 0 in the array contains number of
                                                            * A+ blood packs in this bank*/
      
        /* update::::no need
        public bool DonateAccept(blood_types b, User u)
        {

            bool accept_donate_flag=false;     //ask the blood bank if the user with email ((u.email)) already supplied the blood pack or not

            if (accept_donate_flag)
            {
                add_blood_type(b);       //add the blood type to the array if accepted by the bank
                return true;
            }
            else
            {
                return false;
            }
        }
        */


        public override void Login(string _email, string _password) { throw new NotImplementedException(); }
        public override void ProfileEdit(object _any) { throw new NotImplementedException(); }
        public override void FrogetPass(string _email) {

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
        public override void DeletAccount(string _email, string _password) { throw new NotImplementedException(); }
        public override void Request_Blood(string _username, string _useremail, string _bloodBankName, string _PageType, int amount)
        {
            string [] email_col = new string[2] { "bb_email", "bb_mobile" };
            string Quary = "select * from Bloodbank where bb_name='" + _bloodBankName + "'";
            string []Bloodbankinfo = DatabaseHandler.getvarfromDB(Quary, email_col);
            if (Bloodbankinfo[0] != string.Empty)
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential("life.saver.admon@gmail.com", "12345.life");
                client.EnableSsl = true;
                MailMessage mesaage = new MailMessage("life.saver.admon@gmail.com", Bloodbankinfo[0], string.Format("{0} Emergency situation",_username), string.Format("The {0} in life saver services system needs {1} pages from type {2}." +
                    "Please contact him on {3} or ",_username, amount, _PageType, _useremail, Bloodbankinfo[1]));
                mesaage.IsBodyHtml = false;
                client.Send(mesaage);
                MessageBox.Show("They will contact you shortly by mail or mobile!");
            }
        }

    }
}
