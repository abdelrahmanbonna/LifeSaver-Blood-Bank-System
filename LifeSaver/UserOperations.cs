using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;

namespace LifeSaver
{
    class UserOperations
    {
        public static User user = new User();

        public static bool Login(string email, string password)
        {
            string[] cols = new string[] { "users_email", "users_password","users_deleted","users_name","users_id" };
            string q = "select * from Users where users_email='"+ email + "' and users_password='"+password+"'";
            string[] results = DatabaseHandler.getvarfromDB(q, cols);
            if (results == null)
                return false;
            user.Email = email;
            user.Name = results[3].ToString();
            user.id = results[4].ToString();
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

        public static bool signUp(User user)
        {
            String query1 = "Select * from Bloodbank.Users where users_email ='" + user.Email + "'; ";
            String output = DatabaseHandler.getvarfromDB(query1, "users_email");

            if (output == "")
            {

                String query2 = "INSERT INTO Bloodbank.Users(users_name ,users_email ,users_password " +
                               ",users_deleted ,users_picture ,users_birthdate ,users_healthcon ,users_mobile " +
                               ",users_bloodtype)" +
                               " VALUES('" + user.Name + "' , '" + user.Email + "','" + user.Password + "'," +
                               " 0 ,'" + user.pictureLoc + "','" + user.birthdate + "','" + user.HealthCond + "'" +
                               ",'" + user.mobileNo + "','" + user.BloodType + "'); ";

                DatabaseHandler.insertdatatodatabase(query2);
                return true;
            }
            else
                return false;
        }

        public static void deleteAccount(int userId)
        {
            String query = " UPDATE Bloodbank.Users SET users_deleted = 1 " +
                           " WHERE "+
                           " users_id = '" + userId + "' ;";

            DatabaseHandler.insertdatatodatabase(query);
        }

        /* update ::: no need
        public String Donate(User u)
        {
            if (u.HealthCond == "ok")             //check if the doner's health condition allows him to donate
            {
                //ask the user to choose the blood bank to donate to
                BloodBank bb = new BloodBank();   //the chosen blood bank
                                                  //ask the user if he is at the blood bank or needs the address

                bool at_location = false;                 //a boolean is true if the user at the blood bank

                if (!at_location)                 //he is not at the blood bank location
                {
                    return bb.address;
                }
                else
                {
                    if (bb.DonateAccept(u.BloodType, u))      //pass the blood type of the user to the blood bank to make it accept if supplied
                    {
                        return "Thank you for blood donation you have saved a life <3";
                    }
                    else
                    {
                        return "Please Donate";
                    }
                }
                
            }
            else
            {
                return "We are sorry your health condition doesn't allow you to donate :'(";
            }
        }
        */
        public static bool ProfileEditname(string email,string new_name)
        {
            string cols = "users_id";
            string q = "select * from Users where users_email='" + email + "'";
            string result = DatabaseHandler.getvarfromDB(q, cols);       //get th id of the user email we want to edit
            q = "update Users SET users_name ='" + new_name + "' where users_id='" + result + "'";
            return DatabaseHandler.insertdatatodatabase(q);
        }
        public static bool ProfileEditpic(string email, string new_pic)
        {
            string cols = "users_id";
            string q = "select * from Users where users_email='" + email + "'";
            string result = DatabaseHandler.getvarfromDB(q, cols);       //get th id of the user email we want to edit
            q = "update Users SET users_pictures ='" + new_pic + "' where users_id='" + result + "'";
            return DatabaseHandler.insertdatatodatabase(q);
        }
        public static bool ProfileEditemail(string email,string new_email)
        {
            string cols = "users_id";
            string q = "select * from Users where users_email='" + email + "'";
            string result = DatabaseHandler.getvarfromDB(q, cols);       //get th id of the user email we want to edit
            q = "update Users SET users_email ='" + new_email + "' where users_id='" + result + "'";
            return DatabaseHandler.insertdatatodatabase(q);
        }
        public static bool ProfileEditpassword(string email, string new_password)
        {
            string cols = "users_id";
            string q = "select * from Users where users_email='" + email + "'";
            string result = DatabaseHandler.getvarfromDB(q, cols);       //get th id of the user email we want to edit
            q = "update Users SET users_password ='" + new_password + "' where users_id='" + result + "'";
            return DatabaseHandler.insertdatatodatabase(q);
        }
        public static bool ProfileEdithealth(string email, string new_health)
        {
            string cols = "users_id";
            string q = "select * from Users where users_email='" + email + "'";
            string result = DatabaseHandler.getvarfromDB(q, cols);       //get th id of the user email we want to edit
            q = "update Users SET users_healthcon ='" + new_health + "' where users_id='" + result + "'";
            return DatabaseHandler.insertdatatodatabase(q);
        }
        public static bool ProfileEditmobile(string email, string new_mob)
        {
            string cols = "users_id";
            string q = "select * from Users where users_email='" + email + "'";
            string result = DatabaseHandler.getvarfromDB(q, cols);       //get th id of the user email we want to edit
            q = "update Users SET users_mobile ='" + new_mob + "' where users_id='" + result + "'";
            return DatabaseHandler.insertdatatodatabase(q);
        }

        public static bool ProfileEditdelet(string email, string stats)
        {
            string cols = "users_id";
            string q = "select * from Users where users_email='" + email + "'";
            string result = DatabaseHandler.getvarfromDB(q, cols);       //get th id of the user email we want to edit
            q = "update Users SET users_deleted ='" + stats + "' where users_id='" + result + "'";
            return DatabaseHandler.insertdatatodatabase(q);
        }
        public static void Request_Blood(string _username, string _useremail, string _bloodBankName, string _PageType, int amount)
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
                    "Please contact him on {3}", _username, amount, _PageType, _useremail));
                mesaage.IsBodyHtml = false;
                client.Send(mesaage);
                MessageBox.Show("They will contact you shortly by mail!");
            }
        }
    }
}
