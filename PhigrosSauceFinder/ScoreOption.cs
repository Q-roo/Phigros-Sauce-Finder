using System;
using System.Collections.Generic;
using System.Text;

namespace PhigrosSauceFinder
{
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
