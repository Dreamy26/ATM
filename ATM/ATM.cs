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

        public static void Register(string name, string password)
        {
            
        }

        public static void Login(string userName, string password)
        {
            
        }

        // The following mthods should only work if there's a logged in account. 
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
