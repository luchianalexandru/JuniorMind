using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballOOP
{
    public class Match
    {
         public string winningTeam;
         public string losingTeam;
         public int winningGoals;
         public int losingGoals;
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
        private Match[] matches;
        public Leg()
        {
            matches = new Match[0];
        }

        public void AddMatch(Match match)
        {
            Array.Resize(ref matches, matches.Length + 1);
            matches[matches.Length - 1] = match;
        }

        public int CountMatches()
        {
            return matches.Length;
        }

        public int CountTotalGoals()
        {
            int count = 0;
            for (int i = 0; i < matches.Length; i++)
            {
                count += matches[i].winningGoals + matches[i].losingGoals;
            }
            return count;
        }
    };
}
