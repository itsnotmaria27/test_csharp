using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class GameMessagesTests
    {
        [TestMethod()]
        public void WelcomeMessage_ShouldPrintCorrectText()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            int range = 10;
            int maxTries = 4;
            Difficulty difficulty = Difficulty.Medium;

            GameMessages.WelcomeMessage(range, maxTries, difficulty);
            string output = stringWriter.ToString().Trim();

            Assert.IsTrue(output.Contains($"Загадано число от 0 до {range - 1}"));
            Assert.IsTrue(output.Contains($"У тебя есть {maxTries} попыток"));
        }

        [TestMethod()]
        public void GuessFeedback_ShouldSayNumberIsSmaller_WhenGuessIsHigher()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            int guess = 15;
            int target = 10;

            GameMessages.GuessFeedback(guess, target);
            string output = stringWriter.ToString().Trim();

            Assert.IsTrue(output.Contains("Загаданное число меньше."));
        }

        [TestMethod()]
        public void GuessFeedback_ShouldSayNumberIsBigger_WhenGuessIsLower()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            int guess = 5;
            int target = 10;

            GameMessages.GuessFeedback(guess, target);
            string output = stringWriter.ToString().Trim();

            Assert.IsTrue(output.Contains("Загаданное число больше."));
        }
    }
}