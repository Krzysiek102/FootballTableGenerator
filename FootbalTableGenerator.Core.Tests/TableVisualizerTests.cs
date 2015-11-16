using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core.Tests
{
    [TestFixture]
    public class TableVisualizerTests
    {
        [Test]
        public void VisualizeAfterOneMatch()
        {
            //Arrange
            IEnumerable<TeamInTable> teamsInTable = new List<TeamInTable>
            {
                new TeamInTable()
                {
                    Position = 1,
                    FootballTeamResultsSummary = new TeamResultsSummary()
                    {
                        Team = "Poland",
                        Points = 3,
                        GoalsScored = 2,
                        GoalsLost = 0
                    }
                },
                new TeamInTable()
                {
                    Position = 2,
                    FootballTeamResultsSummary = new TeamResultsSummary()
                    {
                        Team = "Germany",
                        Points = 0,
                        GoalsScored = 0,
                        GoalsLost = 2
                    }
                },
            };

            //Act
            TableVisualizer tableVisualiser = new TableVisualizer();
            string visualisedTable = tableVisualiser.Visualize(teamsInTable);

            string expectedTable =
@"1. Poland 3 2:0 2
2. Germany 0 0:2 -2";

            Assert.That(visualisedTable == expectedTable);
        }
    }
}
