using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string input;
            string withdraw = "W";
            string deposit = "D";
            string decision;
            int quit;
            
            int balance = 500;
            int amount;

            Atm myAtm = new Atm(500);
            
            Console.WriteLine("Welcome to Clayton Financial ATM's");

            while (repeat)
            {
                Console.WriteLine("Your current balance is $" + balance + ". Enter W to Withdraw or D to Deposit");
                decision = Console.ReadLine();

                if (decision == withdraw || decision == deposit)
                {
                    Console.WriteLine("Select the amount to the nearest whole dollar");
                    input = Console.ReadLine();
                    amount = int.Parse(input);

                    balance = myAtm.processtransaction(decision, amount);
                  
                    Console.WriteLine("Your new balance is $" + balance);
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }

                Console.WriteLine("Enter 1 to contine or 0 to quit");
                input = Console.ReadLine();
                quit = int.Parse(input);

                if (quit == 0)
                {
                    Console.WriteLine("Thank you for choosing Clayton Financial. Have a great day!");
                    repeat = false;
                }
            }
        }
    }
}