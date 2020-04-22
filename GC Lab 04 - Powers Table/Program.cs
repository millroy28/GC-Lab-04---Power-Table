using System;

namespace GC_Lab_04___Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction to user
            Console.WriteLine("Welcome to the Powers Table program");
            Console.WriteLine("This program will take an integer of your choice and display the squares and cubes up to that number.");
            
            //Sets user prompts
            string intPrompt = "Please enter an integer: ";
            string contPrompt = "Would you like to run the program again? y/n: ";

            bool contRun = true;

            //Propts user for int/returns output
            while(contRun)
            {
                                
                int userInt = GetUserInt(intPrompt);

                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("=======\t=======\t=======");
                for (int i = 1; i <= userInt; i++)
                {
                    Console.WriteLine(i + "\t" + (i * i) + "\t" + (i * i * i));
                }

                Console.WriteLine("");
                contRun = GetYesOrNo(contPrompt);

            }

            Console.WriteLine("Goodbye!");


        }

        public static bool GetYesOrNo(string prompt)
        {
            //Prompts user for y/n; returns true for y and false for n
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine().ToLower();

                if (input == "y")
                    return true;
                else if (input == "n")
                    return false;
                else
                    Console.WriteLine("I'm sorry, I didn't get that.");
            }
        }

        public static int GetUserInt(string prompt)
        {
            //Prompts user for an int, validates, returns
            int num;
            while(true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                bool isInt = int.TryParse(input, out num);

                if (isInt)
                    return num;
                else
                    Console.WriteLine("I'm sorry, your input wasn't valid. Please try again.");

            }
        }

    }
}
