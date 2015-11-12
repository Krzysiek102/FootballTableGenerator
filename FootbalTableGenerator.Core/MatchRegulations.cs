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

        public void AddPointsAndGoals(FootbalMatch match, TeamResultsSummary hostResults, TeamResultsSummary guestResults)
        {
            if (match.NumberOfGoalsScoredByHosts > match.NumberOfGoalsScoredByGuests)
            {
                hostResults.Points += NumerOfPointForWin;
            }
            else if (match.NumberOfGoalsScoredByHosts < match.NumberOfGoalsScoredByGuests)
            {
                guestResults.Points += NumerOfPointForWin;
            }
            else
            {
                hostResults.Points += NumerOfPointForDraw;
                guestResults.Points += NumerOfPointForDraw;
            }
            hostResults.GoalsScored += match.NumberOfGoalsScoredByHosts;
            hostResults.GoalsLost += match.NumberOfGoalsScoredByGuests;

            guestResults.GoalsScored += match.NumberOfGoalsScoredByGuests;
            guestResults.GoalsLost += match.NumberOfGoalsScoredByHosts;
        }
    }
}
