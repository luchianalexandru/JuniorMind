using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Football
{
    [TestClass]
    public class Football
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

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
    }
}
