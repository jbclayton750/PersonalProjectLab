using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string input;
            int quit;

            Console.WriteLine("Welcome to Clayton Financial ATM's");

            while (repeat)
            {
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