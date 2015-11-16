using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core
{
    public class TeamResultsSummaryComparer : IComparer<TeamResultsSummary>
    {
        public int Compare(TeamResultsSummary teamX, TeamResultsSummary teamY)
        {
            if (teamX.Points > teamY.Points) return 1;
            if (teamX.Points == teamY.Points)
            {
                if (teamX.GoalDifference > teamY.GoalDifference) return 1;
                if (teamX.GoalDifference == teamY.GoalDifference)
                {
                    if (teamX.GoalsScored > teamY.GoalsScored) return 1;
                    if (teamX.GoalsScored == teamY.GoalsScored) return 0;
                }
            }
            return -1;
        }
    }
}
