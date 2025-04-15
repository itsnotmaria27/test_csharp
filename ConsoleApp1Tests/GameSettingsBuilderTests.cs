using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class GameSettingsBuilderTests
    {
        [TestMethod]
        public void GameSettingsBuilder_ShouldApplyDifficultyCorrectly()
        {
            var builder = new GameSettingsBuilder()
                .WithRange(16) 
                .WithDifficulty(Difficulty.Medium);

            var settings = builder.Build();

            Assert.AreEqual(3, settings.MaxTries);
        }
    }
}