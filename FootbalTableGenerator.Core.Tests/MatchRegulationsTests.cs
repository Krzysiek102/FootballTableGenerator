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
            //Arrnage
            MatchRegulations matchRegulations = new MatchRegulations();
            FootballMatch match = new FootballMatch()
            {
                HostTeam = "Poland",
                GuestTeam = "Germany",
                NumberOfGoalsScoredByHosts = 2,
                NumberOfGoalsScoredByGuests = 0
            };
            TeamResultsSummary hostTeam = new TeamResultsSummary()
            {
                Team = "Poland",
                GoalsLost = 0,
                GoalsScored = 0,
                Points = 0
            };
            TeamResultsSummary guestTeam = new TeamResultsSummary()
            {
                Team = "Germany",
                GoalsLost = 0,
                GoalsScored = 0,
                Points = 0
            };

            //Act
            matchRegulations.AddPointsAndGoals(match, hostTeam, guestTeam);

            Assert.That(hostTeam.Points == 3);
            Assert.That(hostTeam.GoalsScored == 2);
            Assert.That(hostTeam.GoalsLost == 0);

            Assert.That(guestTeam.Points == 0);
            Assert.That(guestTeam.GoalsScored == 0);
            Assert.That(guestTeam.GoalsLost == 2);
        }
    }
}
