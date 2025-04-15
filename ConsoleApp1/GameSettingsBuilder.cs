using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GameSettingsBuilder
    {
        private int _range = 10; 
        private Difficulty _difficulty = Difficulty.Easy;

        public GameSettingsBuilder WithRange(int range)
        {
            _range = range;
            return this;
        }

        public GameSettingsBuilder WithDifficulty(Difficulty difficulty)
        {
            _difficulty = difficulty;
            return this;
        }

        public GameSettings Build()
        {
            return new GameSettings(_range, _difficulty);
        }
    }
}
