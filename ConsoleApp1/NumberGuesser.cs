using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumberGuesser
    {
        private readonly GameSettings _settings;
        private readonly int _targetNumber;
        private int _lastGuess = -1;

        public NumberGuesser(GameSettings settings)
        {
            _settings = settings;
            _targetNumber = new Random().Next(0, settings.Range); ;
        }

        public void StartGame()
        {
            GameMessages.WelcomeMessage(_settings.Range, _settings.MaxTries, _settings.Difficulty);
            bool guessed = false;
            for (int tryCount = 1; tryCount <= _settings.MaxTries; tryCount++)
            {
                Console.WriteLine($"\nПопытка {tryCount}. Введи число:");
                int guess = GetValidGuess();

                if (guess == _lastGuess)
                {
                    GameMessages.DuplicateMessage();
                    tryCount--;
                    continue;
                }
                _lastGuess = guess;

                if (guess == _targetNumber)
                {
                    GameMessages.WinMessage();
                    guessed = true;
                    break;
                }
                GameMessages.GuessFeedback(guess, _targetNumber);
            }
            if (!guessed)
            {
                GameMessages.LoseMessage(_targetNumber);
            }
        }
        public int GetValidGuess()
        {
            int guess;
            while (!int.TryParse(Console.ReadLine(), out guess) || guess < 0 || guess >= _settings.Range)
            {
                GameMessages.InvalidMessage(_settings.Range);
            }
            return guess;
        }
    }
}
