using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace PhigrosSauceFinder
{
    class Program
    {
        //list of all the charts that can result in the given score
        static List<ScoreOption> scoreOptions = new List<ScoreOption>();

        static void Main(string[] args)
        {
            string wikiJson = ChartCollection.GetWikiJson();

            //get the target score
            Console.Write("score: ");
            int targetScore = int.Parse(Console.ReadLine());

            //loading the json and getting working with it
            //this makes everything null, a problem for the future me
            var settings = new JsonSerializerSettings
            {
                Error = (obj, args) =>
                {
                    var contextErrors = args.ErrorContext;
                    contextErrors.Handled = true;
                }
            };

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
                if(root.ez != null)
                {
                    Console.WriteLine($"trying: {chartName} (Easy)");
                    ScoreCombinationCalculator(root.ez.notes, targetScore, chartName, "ez", root.ez.level);
                }

                if (root.hd != null)
                {
                    Console.WriteLine($"trying: {chartName} (Hard)");
                    ScoreCombinationCalculator(root.hd.notes, targetScore, chartName, "hd", root.hd.level);
                }

                if (root.@in != null)
                {
                    Console.WriteLine($"trying: {chartName} (Insane)");
                    ScoreCombinationCalculator(root.@in.notes, targetScore, chartName, "in", root.@in.level);
                }

                if (root.legacy != null)
                {
                    Console.WriteLine($"trying: {chartName} (Legacy)");
                    ScoreCombinationCalculator(root.legacy.notes, targetScore, chartName, "legacy", root.legacy.level);
                }

                if (root.at != null)
                {
                    Console.WriteLine($"trying: {chartName} (Another)");
                    ScoreCombinationCalculator(root.at.notes, targetScore, chartName, "at", root.at.level);
                }

                if (root.sp != null)
                {
                    Console.WriteLine($"trying: {chartName} (Special)");
                    ScoreCombinationCalculator(root.sp.notes, targetScore, chartName, "sp", root.sp.level);
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
                    Console.WriteLine($"song: {scoreOption.song}\ndifficulty: {scoreOption.difficulty}({scoreOption.chartConstant})\nperfect: {scoreOption.perfect}\ngood: {scoreOption.good}\nmax combo: {scoreOption.maxCombo}");
                }
            }
            else
            {
                Console.WriteLine("no results");
            }

            Console.ReadLine();
        }

        static void ScoreCombinationCalculator(int noteCount, int targetScore, string song, string difficulty, double chartConstant)
        {
            int availableNotes;
            //go trough all the possible note combinations based on the current max combo
            for (int maxCombo = 1; maxCombo <= noteCount; maxCombo++)
            {
                //Console.WriteLine($"notes: {noteCount}, max combo: {maxCombo}, unavailablle notes: {noteCount / (maxCombo + 1)}");
                availableNotes = noteCount - noteCount / (maxCombo + 1);
                //Console.WriteLine(availableNotes);
                for (int perfect = 0; perfect <= availableNotes; perfect++)
                {
                    if (perfect + 0 == maxCombo)
                    {
                        if(ScoreCalculation(perfect, 0, maxCombo, noteCount) == targetScore)
                        {
                            scoreOptions.Add(new ScoreOption(perfect, 0, maxCombo, song, difficulty, chartConstant));
                        }
                    }
                    //Console.WriteLine(perfect);

                    for (int good = 1; good + perfect <= noteCount; good++)
                    {
                        if (good + perfect == maxCombo)
                        {
                            if(ScoreCalculation(perfect, good, maxCombo, noteCount) == targetScore)
                            {
                                scoreOptions.Add(new ScoreOption(perfect, good, maxCombo, song, difficulty, chartConstant));
                            }
                        }
                        //Console.WriteLine(good); 
                    }
                }
            }
        }

        static int ScoreCalculation(int perfect, int good, int maxCombo, int noteCount)
        {
            var accuracy = (perfect + good * 0.65) / noteCount;
            var comboPercentage = maxCombo / noteCount;
            var score = 900000 * accuracy + 100000 * comboPercentage;
            //Console.WriteLine($"perfect: {perfect}, good: {good}, max combo: {maxCombo}\naccuracy: {accuracy}, combo percentage: {comboPercentage}, score: {score}, score(rounded): {Math.Round(score)}");

            return ((int)Math.Round(score));
        }
    }

    class ScoreOption
    {
        public int perfect;
        public int good;
        public int maxCombo;
        public string song;
        public string difficulty;
        public double chartConstant;

        public ScoreOption(int _perfect, int _good, int _maxCombo, string _song, string _difficulty, double _chartConstant)
        {
            perfect = _perfect;
            good = _good;
            maxCombo = _maxCombo;
            song = _song;
            difficulty = _difficulty;
            chartConstant = _chartConstant;
        }
    }
}
