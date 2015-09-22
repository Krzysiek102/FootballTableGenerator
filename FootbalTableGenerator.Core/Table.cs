using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core
{
    public class Table
    {
        private List<TeamResultsSummary> teamsResults
            = new List<TeamResultsSummary>();

        private readonly IComparer<TeamResultsSummary> teamComparator;


        public Table(IComparer<TeamResultsSummary> teamComparator)
        {
            this.teamComparator = teamComparator;
        }

        public const int NumerOfPointForWin = 3;

        public const int NumerOfPointForDraw = 1;

        public void RegisterMatch(MatchResult match)
        {
            TeamResultsSummary host = GetTeamFromTeamsResults(match.HostTeam);
            TeamResultsSummary guest = GetTeamFromTeamsResults(match.GuestTeam);
            AddPointsAddGoals(match, host, guest);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (TeamInTable teamInTable in GetCurrentTable())
            {
                sb.AppendLine(String.Format("{0}. {1} {2} {3}:{4} {5}", 
                    teamInTable.Position,
                    teamInTable.FootbalTeamResultsSummary.Team.Name,
                    teamInTable.FootbalTeamResultsSummary.Points,
                    teamInTable.FootbalTeamResultsSummary.GoalsScored,
                    teamInTable.FootbalTeamResultsSummary.GoalsLost,
                    teamInTable.FootbalTeamResultsSummary.GoalDifference));
            }
            return sb.ToString();
        }

        public IEnumerable<TeamInTable> GetCurrentTable()
        {
            teamsResults.Sort(teamComparator);
            teamsResults.Reverse();
            uint currentPosition = 1;
            List<TeamInTable> table = new List<TeamInTable>();
            foreach (TeamResultsSummary teamResultsSummary in teamsResults)
            {
                TeamInTable teamInTable = new TeamInTable();
                teamInTable.FootbalTeamResultsSummary = teamResultsSummary;
                teamInTable.Position = currentPosition;
                table.Add(teamInTable);
                currentPosition++;
            }
            return table;
        }

        private TeamResultsSummary GetTeamFromTeamsResults(Team team)
        {
            TeamResultsSummary resultsSummary = teamsResults.Find(tr => tr.Team.Name == team.Name);
            if (resultsSummary == null)
            {
                resultsSummary = new TeamResultsSummary();
                resultsSummary.Team = team;
                teamsResults.Add(resultsSummary);
            };
            return resultsSummary;
        }

        private void AddPointsAddGoals(MatchResult match, TeamResultsSummary host, TeamResultsSummary guest)
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
