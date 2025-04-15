using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class GameMessages
    {
        public static void WelcomeMessage(int range, int maxTries, Difficulty difficulty)
        {
            Console.WriteLine($"Загадано число от 0 до {range - 1}. Попробуй угадать!");
            Console.WriteLine($"Сложность: {difficulty} | Попыток: {maxTries}");
        }

        public static void InvalidMessage(int range)
        {
            Console.WriteLine($"Введи нормальное число от 0 до {range - 1}!");
        } 
        public static void DuplicateMessage()
        {
            Console.WriteLine("Одинаковое число.");
        }
        public static void GuessFeedback(int guess, int target)
        {
            if (guess > target)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine("Загаданное число больше.");
            }
        }
        public static void WinMessage()
        {
            Console.WriteLine("Your super puper mega ultra");
        } 
        public static void LoseMessage(int target)
        {
            Console.WriteLine($"\nGame over. Было загадано: {target}.");
        }
    }
}
