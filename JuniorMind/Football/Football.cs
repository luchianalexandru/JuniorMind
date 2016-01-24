using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Football
{
    [TestClass]
    public class Football
    {
  
        [TestMethod]
        public void TestsIfTheLastMatchWasAdded()
        {
            AddTheLastMatchOfTheLeg("petrolul", "gloria", 7, 2);
            Assert.AreEqual("petrolul", Leg[3].winningTeam);
            Assert.AreEqual(7, Leg[3].winningGoals);
        }

        [TestMethod]
        public void TestsIfTotalNumberOfGoalsCorrect()
        {
            int c = CalculateTheNumberOfGoalsGivenForTheEntireLeg();
            Assert.AreEqual(14,c);
        }

        [TestMethod]
        public void TestsIfAverageNumberOfGoalsForLegIsCorrect()
        {
            Assert.AreEqual(4, CalculateTheAverageNumberOfGoalsForEntireLeg());
        }

        [TestMethod]
        public void TestsIfGoalDifferenceInAMatchWorks()
        {
            Assert.AreEqual(6, GetGoalDifferenceInAMatch(1));
        }

        [TestMethod]
        public void TestsifRemovingWorks()
        {
            RemovesTheMatchWithTheBiggestDifferenceOfGoals();
            Assert.AreEqual(2, Leg.Length);
        }

        [TestMethod]
        public void TestsifRemovingWorksTwice()
        {
            RemovesTheMatchWithTheBiggestDifferenceOfGoals();
            RemovesTheMatchWithTheBiggestDifferenceOfGoals();
            Assert.AreEqual(1, Leg.Length);
        }

        [TestMethod]
        public void TestsWhichTeamNameHasLowestAverage()
        {
            
            Assert.AreEqual("gloria", ReturnTeamNameForLowestAverageOfGoals());
        }

        public struct Match
        {
            public string winningTeam;
            public string losingTeam;
            public int winningGoals;
            public int losingGoals;
        }

        public Match[] Leg =
        {
            new Match { winningTeam = "avantul" , losingTeam = "gloria", winningGoals = 1, losingGoals = 1 },
            new Match { winningTeam = "sageata", losingTeam = "concordia", winningGoals = 7, losingGoals = 1 },
            new Match { winningTeam = "astra" , losingTeam = "ceahlaul", winningGoals = 3, losingGoals = 1 }
        };

        public void AddTheLastMatchOfTheLeg(string name1, string name2, int goalsGiven, int goalsReceived)
        {
            Array.Resize(ref Leg, Leg.Length + 1);
            Leg[Leg.Length - 1].winningTeam = name1;
            Leg[Leg.Length - 1].losingTeam = name2;
            Leg[Leg.Length - 1].winningGoals = goalsGiven;
            Leg[Leg.Length - 1].losingGoals = goalsReceived;
        }

        int CalculateTheNumberOfGoalsGivenForTheEntireLeg()
        {
            int counter = 0;
            for(int i = 0; i < Leg.Length; i++)
            {
                counter = counter + Leg[i].winningGoals+Leg[i].losingGoals;
            }
            return counter;
        }
        
        decimal CalculateTheAverageNumberOfGoalsForEntireLeg()
        {
            return CalculateTheNumberOfGoalsGivenForTheEntireLeg() / Leg.Length;
        }

        int GetGoalDifferenceInAMatch(int i)
        {
            return Leg[i].winningGoals - Leg[i].losingGoals;
        }
       
        public void RemovesTheMatchWithTheBiggestDifferenceOfGoals()
        {
            int maxDiff = GetGoalDifferenceInAMatch(0);
            int positionOfMatchInLeg = 0;
            for(int i = 0; i < Leg.Length; i++)
            {
                if (maxDiff < GetGoalDifferenceInAMatch(i))
                {
                    maxDiff = GetGoalDifferenceInAMatch(i);
                    positionOfMatchInLeg = i;
                }
            }

            for ( int j = positionOfMatchInLeg; j < Leg.Length-1; j++)
            {
                Leg[j] = Leg[j + 1];
            }
            Array.Resize(ref Leg, Leg.Length - 1);
        }

        string ReturnTeamNameForLowestAverageOfGoals()
        {
            decimal counter = GetAverageOfGoalsForATeam(Leg[0].losingGoals, Leg[0].winningGoals);
            string teamName = Leg[0].losingTeam;
            for (int i = 1; i < Leg.Length; i++)
            {
                if (counter < GetAverageOfGoalsForATeam(Leg[i].losingGoals, Leg[i].winningGoals))
                {
                    counter = GetAverageOfGoalsForATeam(Leg[i].losingGoals, Leg[i].winningGoals);
                    teamName = Leg[i].losingTeam;
                }
            }
            return teamName;
        }

        decimal GetAverageOfGoalsForATeam(int goalsGiven, int goalsReceived)
        {
            return goalsGiven / goalsReceived;
        }
    }
}
