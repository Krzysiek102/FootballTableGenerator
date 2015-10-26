using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core
{
    public class Table
    {
        private List<TeamResultsSummary> teamsResults  = new List<TeamResultsSummary>();

        private readonly IComparer<TeamResultsSummary> teamComparator;
        private readonly MatchBuilder matchBuilder;
        private readonly MatchRegulations matchRegulations;

        public Table()
            :this(new MatchBuilder(), new TeamResultsSummaryComparator(), new MatchRegulations())
        { }

        public Table(MatchBuilder matchBuilder, IComparer<TeamResultsSummary> teamComparator,
            MatchRegulations matchRegulations)
        {
            this.teamComparator = teamComparator;
            this.matchBuilder = matchBuilder;
            this.matchRegulations = matchRegulations;
        }

        public void RegisterMatch(string matchString)
        {
            MatchResult match = matchBuilder.ConstructMatch(matchString);
            TeamResultsSummary host = GetTeamFromTeamsResults(match.HostTeam);
            TeamResultsSummary guest = GetTeamFromTeamsResults(match.GuestTeam);
            matchRegulations.AddPointsAndGoals(match, host, guest);
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
            return sb.ToString().Trim();
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
    }
}
