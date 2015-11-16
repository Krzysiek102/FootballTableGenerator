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

        private readonly MatchBuilder matchBuilder = new MatchBuilder();
        private readonly MatchRegulations matchRegulations = new MatchRegulations();
        private readonly TableVisualizer tableVisualizer = new TableVisualizer();
        private readonly TeamResultsSummarySorter teamResultsSummarySorter = new TeamResultsSummarySorter();

        public void RegisterMatch(string matchString)
        {
            FootballMatch match = matchBuilder.ConstructMatch(matchString);
            TeamResultsSummary hostResults = GetTeamResultsByTeamName(match.HostTeam);
            TeamResultsSummary guestResults = GetTeamResultsByTeamName(match.GuestTeam);
            matchRegulations.AddPointsAndGoals(match, hostResults, guestResults);
        }

        public string Visualize()
        {
            IEnumerable<TeamInTable> teamsEnumeration = teamResultsSummarySorter.Sort(teamsResults);
            return tableVisualizer.Visualize(teamsEnumeration);
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
