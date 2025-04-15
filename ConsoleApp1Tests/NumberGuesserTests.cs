using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class NumberGuesserTests
    {
        [TestMethod()]
        public void StartGame_ShouldDetectCorrectGuess()
        {
            var settings = new GameSettings(10, Difficulty.Medium);
            var game = new NumberGuesser(settings);

            var stringReader = new StringReader("5");
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            game.StartGame();
            string output = stringWriter.ToString();

            Assert.IsTrue(output.Contains("Your super puper mega ultra"), "Игра должна сообщить о победе.");
        }

        [TestMethod()]
        public void GetValidGuess_ShouldRejectInvalidInput()
        {
            var settings = new GameSettings(10, Difficulty.Medium);
            var game = new NumberGuesser(settings);

            var stringReader = new StringReader("abc\n5");
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            int guess = game.GetValidGuess(); 

            Assert.AreEqual(5, guess, "Должно вернуться последнее корректное число.");
            Assert.IsTrue(stringWriter.ToString().Contains("Серьёзно?"), "Должно выводиться сообщение об ошибке.");
        }

        [TestMethod()]
        public void StartGame_ShouldDetectDuplicateGuesses()
        {
            var settings = new GameSettings(10, Difficulty.Medium);
            var game = new NumberGuesser(settings);

            var stringReader = new StringReader("5\n5\n3");
            Console.SetIn(stringReader);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            game.StartGame();
            string output = stringWriter.ToString();

            Assert.IsTrue(output.Contains("Опять то же самое? Лошара..."), "Должно быть сообщение о повторном вводе.");
        }
    }
}