using System;
namespace ATM
{
    // The account object will need to track the following, String Name, String Password, Int Balance
    public class Account
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        public Account()
        {

        }

        public Account(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
