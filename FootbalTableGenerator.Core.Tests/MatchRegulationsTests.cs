using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core.Tests
{
    [TestFixture]
    public class MatchRegulationsTests
    {
        [Test]
        public void HostsWin()
        {
            //Arrange
            MatchRegulations matchRegulations = new MatchRegulations();
            MatchBuilder matchBuilder = new MatchBuilder();
            FootbalMatch match = matchBuilder.ConstructMatch("Poland - Germany 2:0");
            TeamResultsSummary hostResults = new TeamResultsSummary();
            TeamResultsSummary guestResults = new TeamResultsSummary();

            //Act
            matchRegulations.AddPointsAndGoals(match, hostResults, guestResults);

            //Assert
            Assert.That(hostResults.Points == 3);
            Assert.That(hostResults.GoalsScored == 2);
            Assert.That(hostResults.GoalsLost == 0);

            Assert.That(guestResults.Points == 0);
            Assert.That(guestResults.GoalsScored == 0);
            Assert.That(guestResults.GoalsLost == 2);
        }
    }
}
