using System;
using System.Threading;

namespace PhigrosSauceFinder
{
    class MainMenu
    {
        static void WriteOption(string optionID, string optionName)
        {
            Console.WriteLine($"[{optionID}] {optionName}");
        }

        public static void Menu()
        {
            for (; ; )
            {
                Console.Clear();

                WriteOption("1", "Calculate sauce score");
                WriteOption("2", "Calculate minimum requirement");
                WriteOption("3", "Exit");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    SauceCalculator.SauceCalculation();
                }

                else if (input == "2")
                {
                    Console.Clear();
                    MinimumRequirementCalculator.RequirementCalculation();
                }

                else if (input == "3")
                {
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("Choose a valid option!");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
