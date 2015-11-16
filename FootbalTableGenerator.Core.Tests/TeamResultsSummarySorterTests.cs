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
        [Test]
        public void SortTableAfterOneMatch()
        {
            //Arrange
            TeamResultsSummarySorter teamResultsSummarySorter = new TeamResultsSummarySorter();
            TeamResultsSummary germanySummary = new TeamResultsSummary()
            {
                Team = "Germany",
                GoalsScored = 0,
                Points = 0,
                GoalsLost = 2,
            };

            TeamResultsSummary polandSummary = new TeamResultsSummary()
            {
                Team = "Poland",
                GoalsScored = 2,
                Points = 3,
                GoalsLost = 0,
            };


            List<TeamResultsSummary> teamsResults = new List<TeamResultsSummary>()
            { 
                germanySummary,
                polandSummary
            };

            //Act
            IEnumerable<TeamInTable> sortedTeamResults = teamResultsSummarySorter.Sort(teamsResults);

            //Assert
            List<TeamInTable> sortedTeamResultsList = sortedTeamResults.ToList();

            Assert.That(sortedTeamResultsList[0].Position == 1);
            Assert.That(sortedTeamResultsList[1].Position == 2);
            Assert.That(sortedTeamResultsList[0].FootballTeamResultsSummary == polandSummary);
            Assert.That(sortedTeamResultsList[1].FootballTeamResultsSummary == germanySummary);
        }
    }
}
