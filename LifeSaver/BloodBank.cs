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


        

    }
}
