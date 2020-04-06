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
            input = Console.ReadLine();
            quit = int.Parse(input);

                       
            while (repeat)
            {
                Console.WriteLine("Welcome to Clayton Financial ATM's");


                Console.WriteLine("Enter 1 to contine or 0 to quit");
                Console.ReadLine();

                if (quit == 0)
                {
                    repeat = false;
                }
            }

        }
    }
}