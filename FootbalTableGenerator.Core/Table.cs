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

        private readonly IComparer<TeamResultsSummary> teamComparator = new TeamResultsSummaryComparator();
        private readonly MatchBuilder matchBuilder = new MatchBuilder();
        private readonly MatchRegulations matchRegulations = new MatchRegulations();
        private readonly TableVisualizer tableVisualizer = new TableVisualizer();

        public void RegisterMatch(string matchString)
        {
            FootbalMatch match = matchBuilder.ConstructMatch(matchString);
            TeamResultsSummary hostResults = GetTeamResultsByTeamName(match.HostTeam);
            TeamResultsSummary guestResults = GetTeamResultsByTeamName(match.GuestTeam);
            matchRegulations.AddPointsAndGoals(match, hostResults, guestResults);
        }

        public string Visualize()
        {
            IEnumerable<TeamInTable> teamsEnumeration = GetCurrentTable();
            return tableVisualizer.Visualize(teamsEnumeration);
        }

        private IEnumerable<TeamInTable> GetCurrentTable()
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

        private TeamResultsSummary GetTeamResultsByTeamName(string team)
        {
            TeamResultsSummary resultsSummary = teamsResults.Find(tr => tr.Team == team);
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
