using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GameSettings
    {
        public int Range { get; }
        public int MaxTries { get; }
        public Difficulty Difficulty { get; }

        public GameSettings(int range, Difficulty difficulty)
        {
            Range = range;
            Difficulty = difficulty;

            int baseTries = (int)Math.Ceiling(Math.Log2(range));

            MaxTries = difficulty switch
            {
                Difficulty.Easy => baseTries,
                Difficulty.Medium => Math.Max(1, baseTries - 1), 
                Difficulty.Hard => Math.Max(1, baseTries - 2),   
                _ => baseTries
            };
        }
    }
}
