using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballOOP
{
    class Football
    {
        public class Match
        {
            private string winningTeam;
            private string losingTeam;
            private int winningGoals;
            private int losingGoals;
            public Match(string winningTeam, string losingTeam, int winningGoals, int losingGoals)
            {
                this.winningTeam = winningTeam;
                this.losingTeam = losingTeam;
                this.winningGoals = winningGoals;
                this.losingGoals = losingGoals;
            }
        }

        public class Leg
        {
            Match newMatch1 = new Match("avantul", "gloria", 1, 1);
            Match newMatch2 = new Match("sageata", "concordia", 7, 1);
            Match newMatch3 = new Match("astra", "ceahlaul", 3, 1);
        };
    }
}
