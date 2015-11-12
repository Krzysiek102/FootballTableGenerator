using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core
{
    public class MatchRegulations
    {
        public const int NumerOfPointForWin = 3;
        public const int NumerOfPointForDraw = 1;

        public void AddPointsAndGoals(FootbalMatch match, TeamResultsSummary host, TeamResultsSummary guest)
        {
            if (match.NumberOfGoalsScoredByHosts > match.NumberOfGoalsScoredByGuests)
            {
                host.Points += NumerOfPointForWin;
            }
            else if (match.NumberOfGoalsScoredByHosts < match.NumberOfGoalsScoredByGuests)
            {
                guest.Points += NumerOfPointForWin;
            }
            else
            {
                host.Points += NumerOfPointForDraw;
                guest.Points += NumerOfPointForDraw;
            }
            host.GoalsScored += match.NumberOfGoalsScoredByHosts;
            host.GoalsLost += match.NumberOfGoalsScoredByGuests;

            guest.GoalsScored += match.NumberOfGoalsScoredByGuests;
            guest.GoalsLost += match.NumberOfGoalsScoredByHosts;
        }
    }
}
