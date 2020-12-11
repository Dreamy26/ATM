using System;

namespace ATM
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Would you like to Register (1) or Login (2)?");
            var userResponse = Console.ReadLine();

            if(userResponse == "1")
            {
                Console.Write("Enter Name: ");
                var userName = Console.ReadLine();

                Console.Write("Enter Password: ");
                var password = Console.ReadLine();

                if(ATM.Register(userName, password) == true)
                {
                    Console.WriteLine("You have successfully registered!");
                }
                else
                {
                    Console.WriteLine("Registrations Failed.");
                }
            }

        }
    }
}
