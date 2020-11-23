using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSaver
{
    public abstract class Person
    {

        public string id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }



        public abstract void Login(string _email, string _password);
        public abstract void ProfileEdit(object _any);
        public abstract void FrogetPass(string _email);
        public abstract void DeletAccount(string _email, string _password);
        public abstract void Request_Blood(string _username, string _useremail, string _bloodBankName, string _PageType, int amount);



    }
}
