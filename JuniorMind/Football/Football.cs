using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Football
{
    [TestClass]
    public class Football
    {
  

        public struct Match
        {
            public string winningTeam;
            public int goalsGivenWinningTeam;
            public int goalsReceivedWinningTeam;
            public string losingTeam;
            public int goalsGivenLosingTeam;
            public int goalsReceivedLosingTeam;

        }

        public Match[] Leg =
        {
            new Match { winningTeam = "avantul" , goalsGivenWinningTeam = 1, goalsReceivedWinningTeam = 0, losingTeam = "gloria", goalsGivenLosingTeam = 0, goalsReceivedLosingTeam = 1 },
            new Match { winningTeam = "petrolul" , goalsGivenWinningTeam = 2, goalsReceivedWinningTeam = 1, losingTeam = "gloria", goalsGivenLosingTeam = 1, goalsReceivedLosingTeam = 2 },
            new Match { winningTeam = "avantul" , goalsGivenWinningTeam = 1, goalsReceivedWinningTeam = 0, losingTeam = "petrolul", goalsGivenLosingTeam = 0, goalsReceivedLosingTeam = 1 }
        };

        [TestMethod]
        public void TestsIfTheLastMatchWasAdded()
        {
            AddTheLastMatchOfTheLeg("petrolul", "gloria", 7, 2);
            Assert.AreEqual("petrolul", Leg[3].winningTeam);
            Assert.AreEqual(7, Leg[3].goalsGivenWinningTeam);
        }


        public void AddTheLastMatchOfTheLeg(string name1, string name2, int goalsGiven, int goalsReceived)
        {
            Array.Resize(ref Leg, Leg.Length + 1);
            Leg[Leg.Length - 1].winningTeam = name1;
            Leg[Leg.Length - 1].goalsGivenWinningTeam = goalsGiven;
            Leg[Leg.Length - 1].goalsReceivedWinningTeam = goalsReceived;
            Leg[Leg.Length - 1].losingTeam = name2;
            Leg[Leg.Length - 1].goalsGivenLosingTeam = goalsReceived;
            Leg[Leg.Length - 1].goalsReceivedLosingTeam = goalsGiven;
        }
    }
}
