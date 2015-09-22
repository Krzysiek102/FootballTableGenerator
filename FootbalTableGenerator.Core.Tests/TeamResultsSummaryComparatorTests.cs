using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core.Tests
{
    [TestFixture]
    public class TeamResultsSummaryComparatorTests
    {
        private TeamResultsSummary team1;
        private TeamResultsSummary team2;
        private TeamResultsSummaryComparator comparator;

        [SetUp]
        public void Setup()
        {
            team1 = new TeamResultsSummary();
            team2 = new TeamResultsSummary();
            comparator = new TeamResultsSummaryComparator();
        }

        [Test]
        public void TeamWithLargerNumberOfPointsShouldBeGreater()
        {
            //Arrane
            team1.Points = 6;
            team2.Points = 4;

            //Act
            int comparisonResult = comparator.Compare(team1, team2);

            //Assert
            Assert.AreEqual(1, comparisonResult);
        }

        [Test]
        public void TeamWithEqualPointsAndBetterGoalDifferenceShuldBeGreater()
        {
            //Arrane
            team1.Points = 6;
            team2.Points = 6;

            team1.GoalsScored = 4;
            team1.GoalsLost = 1;

            team2.GoalsScored = 2;
            team2.GoalsLost = 0;

            //Act
            int comparisonResult = comparator.Compare(team1, team2);

            //Assert
            Assert.AreEqual(1, comparisonResult);
        }
    }
}
