using System;
using System.Collections.Generic;
using System.Text;

namespace PhigrosSauceFinder
{
    static class ScoreCalculation
    {
        private static int ScoreCalculator(int perfect, int good, int maxCombo, int noteCount)
        {
            var accuracy = (perfect + good * 0.65) / noteCount;
            var comboPercentage = maxCombo / noteCount;
            var score = 900000 * accuracy + 100000 * comboPercentage;
            //Console.WriteLine($"perfect: {perfect}, good: {good}, max combo: {maxCombo}\naccuracy: {accuracy}, combo percentage: {comboPercentage}, score: {score}, score(rounded): {Math.Round(score)}");

            return ((int)Math.Round(score));
        }

        public static void ScoreCombinationCalculatorForSauce(List<ScoreOption> scoreOptions, int noteCount, int targetScore, string song, string difficulty, double chartConstant)
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
                        if (ScoreCalculator(perfect, 0, maxCombo, noteCount) == targetScore)
                        {
                            scoreOptions.Add(new ScoreOption(perfect, 0, maxCombo, song, difficulty, chartConstant));
                        }
                    }
                    //Console.WriteLine(perfect);

                    for (int good = 1; good + perfect <= noteCount; good++)
                    {
                        if (good + perfect == maxCombo)
                        {
                            if (ScoreCalculator(perfect, good, maxCombo, noteCount) == targetScore)
                            {
                                scoreOptions.Add(new ScoreOption(perfect, good, maxCombo, song, difficulty, chartConstant));
                            }
                        }
                        //Console.WriteLine(good); 
                    }
                }
            }
        }

        public static void ScoreCombinationCalculatorForRequirement(List<ScoreOption> scoreOptions, int noteCount, int targetScore, string song, string difficulty, double chartConstant)
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
                        if (ScoreCalculator(perfect, 0, maxCombo, noteCount) >= targetScore)
                        {
                            scoreOptions.Add(new ScoreOption(perfect, 0, maxCombo, song, difficulty, chartConstant));
                        }
                    }
                    //Console.WriteLine(perfect);

                    for (int good = 1; good + perfect <= noteCount; good++)
                    {
                        if (good + perfect == maxCombo)
                        {
                            if (ScoreCalculator(perfect, good, maxCombo, noteCount) >= targetScore)
                            {
                                scoreOptions.Add(new ScoreOption(perfect, good, maxCombo, song, difficulty, chartConstant));
                            }
                        }
                        //Console.WriteLine(good); 
                    }
                }
            }
        }
    }
}
