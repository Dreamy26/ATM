using System;
using System.Collections.Generic;

namespace ATM
{
    public class ATM
    {
        public List<Account> Accounts = new List<Account>();

        public ATM()
        {

        }

        public string Register(string name, string password)
        {
            return "";
        }

        public string Login(string userName, string password)
        {
            return "";
        }


        public bool Logout()
        {
            return true;
        }

        public string CheckBalance()
        {
            Console.WriteLine("Ballance of account");
            return "";
           
        }

        public static void Deposit(int depositAmount)
        {

        }

        public static void Withdraw()
        {

        }
      
    }
}
