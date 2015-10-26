using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core
{
    public class MatchBuilder
    {
        private Regex matchStringFormat = new Regex(@"(\w+) - (\w+) (\d+):(\d+)");

        public MatchResult ConstructMatch(string matchInput)
        {
            Match match = matchStringFormat.Match(matchInput);
            if (match.Success)
            {
                MatchResult machResult = new MatchResult();
                machResult.HostTeam = new Team { Name = match.Groups[1].Value };
                machResult.GuestTeam = new Team { Name = match.Groups[2].Value };
                machResult.NumberOfGoalsScoredByHosts = Byte.Parse(match.Groups[3].Value);
                machResult.NumberOfGoalsScoredByGuests = Byte.Parse(match.Groups[4].Value);
                return machResult;
            }
            else
            {
                throw new ArgumentException("Invalid match format");
            }
        }
    }
}
