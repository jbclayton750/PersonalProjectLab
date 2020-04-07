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

            Console.WriteLine("Welcome to Clayton Financial ATM's");


            while (repeat)
            {
                Console.WriteLine("Your current balance is $500. Enter W to Withdraw or D to Deposit");
                decision = Console.ReadLine();

                if (decision.Equals(withdraw))
                {
                    Console.WriteLine("Select the amount you would like to withdraw to the nearest whole dollar");
                }

                if (decision.Equals(deposit))
                {
                    Console.WriteLine("Select the amount you wouls like to deposit to the nearest whole dollar");
                }

                Console.WriteLine("Enter 1 to contine or 0 to quit");
                input = Console.ReadLine();
                quit = int.Parse(input);

                if (quit == 0)
                {
                    repeat = false;
                }
            }

        }
    }
}