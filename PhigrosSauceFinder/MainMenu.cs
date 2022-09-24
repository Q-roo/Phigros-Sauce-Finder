using System;
using System.Collections.Generic;
using System.Text;

namespace PhigrosSauceFinder
{
    class MainMenu
    {
        void WriteOption(string optionID, string optionName)
        {
            Console.WriteLine($"[{optionID}] {optionName}");
        }

        void Menu()
        {
            WriteOption("1", "Calculate sauce score");
            WriteOption("2", "Calculate minimum requirement");

            string input = Console.ReadLine();

            if (input == "1")
            {

            }

            else if (input == "2")
            {

            }

            else
            {
                Console.WriteLine("Choose a valid option!");
            }
        }
    }
}
