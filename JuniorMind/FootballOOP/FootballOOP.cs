using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FootballOOP
{
    [TestClass]
    public class FootballOOP
    {
        [TestMethod]
        public void AddNewMatch()
        {
            Leg leg = new Leg();
            leg.AddMatch(new Match("avantul", "gloria", 1, 1));
            Assert.AreEqual(1, leg.CountMatches());
        }

        [TestMethod]
        public void CountTotalGoalsPerLeg()
        {
            Leg leg = new Leg();
            leg.AddMatch(new Match("avantul", "gloria", 1, 1));
            leg.AddMatch(new Match("sageata", "concordia", 7, 1));
            leg.AddMatch(new Match("astra", "ceahlaul", 3, 1));
            Assert.AreEqual(14, leg.CountTotalGoals());
        }
    }
}
