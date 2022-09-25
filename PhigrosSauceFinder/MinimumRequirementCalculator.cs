using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhigrosSauceFinder
{
    static class MinimumRequirementCalculator
    {

        //list of all the charts that can result in the given score
        static List<ScoreOption> scoreOptions = new List<ScoreOption>();

        public static void RequirementCalculation()
        {

            Console.WriteLine("it is strongly recommended to use this feature with locale emulator or in a chinese system language");

            bool isEasy(string difficulty)
            {
                bool _result;
                if (difficulty == "Easy"|| difficulty == "easy" || difficulty == "Ez" || difficulty == "EZ" || difficulty == "ez")
                {
                    _result = true;
                }
                else
                {
                    _result = false;
                }

                return (_result);
            }

            bool isHard(string difficulty)
            {
                bool _result;
                if (difficulty == "Hard" || difficulty == "hard" || difficulty == "Hd" || difficulty == "HD" || difficulty == "hd")
                {
                    _result = true;
                }
                else
                {
                    _result = false;
                }

                return (_result);
            }

            bool isInsane(string difficulty)
            {
                bool _result;
                if (difficulty == "Insane" || difficulty == "insane" || difficulty == "In" || difficulty == "IN" || difficulty == "in")
                {
                    _result = true;
                }
                else
                {
                    _result = false;
                }

                return (_result);
            }

            bool isLegacy(string difficulty)
            {
                bool _result;
                if (difficulty == "Legacy" || difficulty == "legacy")
                {
                    _result = true;
                }
                else
                {
                    _result = false;
                }

                return (_result);
            }

            bool isAnother(string difficulty)
            {
                bool _result;
                if (difficulty == "Another" || difficulty == "another" || difficulty == "At" || difficulty == "AT" || difficulty == "at")
                {
                    _result = true;
                }
                else
                {
                    _result = false;
                }

                return (_result);
            }

            bool isSpecial(string difficulty)
            {
                bool _result;
                if (difficulty == "Special" || difficulty == "special" || difficulty == "Sp" || difficulty == "SP" || difficulty == "sp")
                {
                    _result = true;
                }
                else
                {
                    _result = false;
                }

                return (_result);
            };

            var json = JsonConvert.DeserializeObject<Dictionary<string, object>>(ChartCollection.allCharts);

            //straight from https://stackoverflow.com/questions/47045964/c-sharp-json-to-dictionary-of-objects
            ImOutOfNameIdeas.RecurseDeserialize(json);

            //write out all the chart names
            Console.WriteLine("Choose one of the following charts to calculate the minimum requriment: ");
            foreach (var chart in json.Keys)
            {
                Console.WriteLine(chart);
            }

            //get the chart
            Console.Write("Choose a chart: ");
            string chartName = Console.ReadLine();
            object difficulty = json[@chartName];

            Root root = JsonConvert.DeserializeObject<Root>(@difficulty.ToString());

            //get the difficulty
            Console.WriteLine("Choose a difficulty:");
            DifficultyOptions(root);
            string selectedDifficulty = Console.ReadLine();

            //get the target score
            Console.Write("score: ");
            int targetScore = int.Parse(Console.ReadLine());

            

            if (root.ez != null && isEasy(selectedDifficulty))
            {
                Console.WriteLine($"trying: {chartName} (Easy)");
                ScoreCalculation.ScoreCombinationCalculatorForRequirement(scoreOptions, root.ez.notes, targetScore, chartName, "ez", root.ez.level);
            }

            if (root.hd != null && isHard(selectedDifficulty))
            {
                Console.WriteLine($"trying: {chartName} (Hard)");
                ScoreCalculation.ScoreCombinationCalculatorForRequirement(scoreOptions, root.hd.notes, targetScore, chartName, "hd", root.hd.level);
            }

            if (root.@in != null && isInsane(selectedDifficulty))
            {
                Console.WriteLine($"trying: {chartName} (Insane)");
                ScoreCalculation.ScoreCombinationCalculatorForRequirement(scoreOptions, root.@in.notes, targetScore, chartName, "in", root.@in.level);
            }

            if (root.legacy != null && isLegacy(selectedDifficulty))
            {
                Console.WriteLine($"trying: {chartName} (Legacy)");
                ScoreCalculation.ScoreCombinationCalculatorForRequirement(scoreOptions, root.legacy.notes, targetScore, chartName, "legacy", root.legacy.level);
            }

            if (root.at != null && isAnother(selectedDifficulty))
            {
                Console.WriteLine($"trying: {chartName} (Another)");
                ScoreCalculation.ScoreCombinationCalculatorForRequirement(scoreOptions, root.at.notes, targetScore, chartName, "at", root.at.level);
            }

            if (root.sp != null && isSpecial(selectedDifficulty))
            {
                Console.WriteLine($"trying: {chartName} (Special)");
                ScoreCalculation.ScoreCombinationCalculatorForRequirement(scoreOptions, root.sp.notes, targetScore, chartName, "sp", root.sp.level);
            }

            if (scoreOptions.Count > 0)
            {
                Console.WriteLine($"{scoreOptions.Count} results found: ");
                foreach (ScoreOption scoreOption in scoreOptions)
                {
                    Console.WriteLine($"song: {scoreOption.song}\n      difficulty: {scoreOption.difficulty}({scoreOption.chartConstant})\n            perfect: {scoreOption.perfect}\n            good: {scoreOption.good}\n            max combo: {scoreOption.maxCombo}\n\n");
                }

                Console.WriteLine($"\n\n\nThe minimum requirement for {chartName} ({selectedDifficulty} {scoreOptions[0].chartConstant}) is:\n            perfect: {scoreOptions[0].perfect}\n            good: {scoreOptions[0].good}\n            max combo: {scoreOptions[0].maxCombo}\n\n");
            }
            else
            {
                Console.WriteLine("no results");
            }

            Console.ReadLine();
        }

        private static void DifficultyOptions(Root root)
        {
            if (root.ez != null)
            {
                Console.WriteLine("easy");
            }

            if (root.hd != null)
            {
                Console.WriteLine("hard");
            }

            if (root.@in != null)
            {
                Console.WriteLine("insane");
            }

            if (root.legacy != null)
            {
                Console.WriteLine("legacy");
            }

            if (root.at != null)
            {
                Console.WriteLine("another");
            }

            if (root.sp != null)
            {
                Console.WriteLine("special");
            }
        }
    }
}
