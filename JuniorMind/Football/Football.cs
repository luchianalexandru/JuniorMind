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
            Assert.AreEqual(12,c);
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

        public struct Match
        {
            public string winningTeam;
            public string losingTeam;
            public int winningGoals;
            public int losingGoals;
        }

        public Match[] Leg =
        {
            new Match { winningTeam = "avantul" , losingTeam = "gloria", winningGoals = 1, losingGoals = 0 },
            new Match { winningTeam = "petrolul", losingTeam = "gloria", winningGoals = 7, losingGoals = 1 },
            new Match { winningTeam = "avantul" , losingTeam = "petrolul", winningGoals = 3, losingGoals = 0 }
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
    }
}
