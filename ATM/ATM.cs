using System;
using System.Collections.Generic;

namespace ATM
{
    public static class ATM
    {
        public static List<Account> Accounts = new List<Account>();

        public static Account CurrentlyLoggedInUser { get; set; }

        public static bool Register(string name, string password)
        {
            if (name.Length > 4 && password.Length > 4)
            {
                Account account = new Account(name, password); // Create a new account object and initialize the Properties with the parameters being taken in.          

                Accounts.Add(account); 

                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Login(string userName, string password)
        {
            if(CurrentlyLoggedInUser == null)
            {
                foreach(var account in Accounts)
                {
                    if(account.Name == userName && account.Password == password)
                    {
                        CurrentlyLoggedInUser = account;
                    }
                }
            }
        }

        // The following mthods should only work if there's a logged in account. 
        public static void Logout()
        {
            CurrentlyLoggedInUser = null;
        }

        public static void CheckBalance()
        {
            Console.WriteLine("Balance of account");
            Console.WriteLine($"{CurrentlyLoggedInUser.Balance:C2}");           
        }

        public static void Deposit(int depositAmount)
        {
            CurrentlyLoggedInUser.Balance += depositAmount;
        }

        public static void Withdraw(int withdrawAmount)
        {
            CurrentlyLoggedInUser.Balance -= withdrawAmount;
        }

    }
}
