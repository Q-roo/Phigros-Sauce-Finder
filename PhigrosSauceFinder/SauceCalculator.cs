using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PhigrosSauceFinder
{
    static class SauceCalculator
    {
        //list of all the charts that can result in the given score
        static List<ScoreOption> scoreOptions = new List<ScoreOption>();

        public static void SauceCalculation()
        {

            //get the target score
            Console.Write("score: ");
            int targetScore = int.Parse(Console.ReadLine());

            var json = JsonConvert.DeserializeObject<Dictionary<string, object>>(ChartCollection.allCharts);

            //straight from https://stackoverflow.com/questions/47045964/c-sharp-json-to-dictionary-of-objects
            ImOutOfNameIdeas.RecurseDeserialize(json);

            //obtain all the keys for the dictionary
            foreach (string chartName in json.Keys)
            {
                //iterate through all the objects stored in the dictionary
                object difficulty = json[@chartName];

                Root root = JsonConvert.DeserializeObject<Root>(@difficulty.ToString());

                //begin going through all the charts
                if (root.ez != null)
                {
                    Console.WriteLine($"trying: {chartName} (Easy)");
                    ScoreCalculation.ScoreCombinationCalculatorForSauce(scoreOptions, root.ez.notes, targetScore, chartName, "ez", root.ez.level);
                }

                if (root.hd != null)
                {
                    Console.WriteLine($"trying: {chartName} (Hard)");
                    ScoreCalculation.ScoreCombinationCalculatorForSauce(scoreOptions, root.hd.notes, targetScore, chartName, "hd", root.hd.level);
                }

                if (root.@in != null)
                {
                    Console.WriteLine($"trying: {chartName} (Insane)");
                    ScoreCalculation.ScoreCombinationCalculatorForSauce(scoreOptions, root.@in.notes, targetScore, chartName, "in", root.@in.level);
                }

                if (root.legacy != null)
                {
                    Console.WriteLine($"trying: {chartName} (Legacy)");
                    ScoreCalculation.ScoreCombinationCalculatorForSauce(scoreOptions, root.legacy.notes, targetScore, chartName, "legacy", root.legacy.level);
                }

                if (root.at != null)
                {
                    Console.WriteLine($"trying: {chartName} (Another)");
                    ScoreCalculation.ScoreCombinationCalculatorForSauce(scoreOptions, root.at.notes, targetScore, chartName, "at", root.at.level);
                }

                if (root.sp != null)
                {
                    Console.WriteLine($"trying: {chartName} (Special)");
                    ScoreCalculation.ScoreCombinationCalculatorForSauce(scoreOptions, root.sp.notes, targetScore, chartName, "sp", root.sp.level);
                }
            }
            //ScoreCombinationCalculator(noteCount, targetScore);

            //test write out all the score options
            //todo: add song titles and difficulties to the score options
            if (scoreOptions.Count > 0)
            {
                Console.WriteLine($"{scoreOptions.Count} results found: ");
                foreach (ScoreOption scoreOption in scoreOptions)
                {
                    Console.WriteLine($"song: {scoreOption.song}\n      difficulty: {scoreOption.difficulty}({scoreOption.chartConstant})\n            perfect: {scoreOption.perfect}\n            good: {scoreOption.good}\n            max combo: {scoreOption.maxCombo}\n\n");
                }
            }
            else
            {
                Console.WriteLine("no results");
            }

            Console.ReadLine();
        }
    }


}
