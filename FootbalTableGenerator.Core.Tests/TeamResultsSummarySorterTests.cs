using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core.Tests
{
    
    [TestFixture]
    public class TeamResultsSummarySorterTests
    {
        public void SortTableAfterOneMatch()
        {
            TeamResultsSummarySorter teamResultsSummarySorter = new TeamResultsSummarySorter();
            List<TeamResultsSummary> teamsResults = new List<TeamResultsSummary>()
            { 
                new TeamResultsSummary()
                {
                    Team = "Germany",
                    GoalsScored = 0,
                    Points = 0,
                    GoalsLost = 2,
                },
                new TeamResultsSummary()
                {
                    Team = "Poland",
                    GoalsScored = 2,
                    Points = 3,
                    GoalsLost = 0,
                }
            };

            //IEnumerable< TeamResultsSummary> sortedTeamResults = teamResultsSummarySorter.Sort(teamsResults);
        }
    }
}
