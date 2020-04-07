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
            string subtract;
            string add;
            int delta;
            int balance = 500;


            Console.WriteLine("Welcome to Clayton Financial ATM's");


            while (repeat)
            {
                Console.WriteLine("Your current balance is $" + balance + ". Enter W to Withdraw or D to Deposit");
                decision = Console.ReadLine();

                if (decision.Equals(withdraw))
                {
                    Console.WriteLine("Select the amount you would like to withdraw to the nearest whole dollar");
                    subtract = Console.ReadLine();
                    delta = int.Parse(subtract);
                    balance -= delta;
                }

                if (decision.Equals(deposit))
                {
                    Console.WriteLine("Select the amount you wouls like to deposit to the nearest whole dollar");
                    add = Console.ReadLine();
                    delta = int.Parse(add);
                    balance += delta;
                }

                Console.WriteLine("Your new balance is " + balance);

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