using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core
{
    public class TableVisualizer
    {
        public string Visualize(IEnumerable<TeamInTable> table)
        {
            StringBuilder sb = new StringBuilder();
            foreach (TeamInTable teamInTable in table)
            {
                sb.AppendLine(String.Format("{0}. {1} {2} {3}:{4} {5}",
                    teamInTable.Position,
                    teamInTable.FootbalTeamResultsSummary.Team,
                    teamInTable.FootbalTeamResultsSummary.Points,
                    teamInTable.FootbalTeamResultsSummary.GoalsScored,
                    teamInTable.FootbalTeamResultsSummary.GoalsLost,
                    teamInTable.FootbalTeamResultsSummary.GoalDifference));
            }
            return sb.ToString().Trim();
        }
    }
}
