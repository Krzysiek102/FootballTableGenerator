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
        [Test]
        public void TeamWithLargerNumberOfPointsShouldBeGreater()
        {
            //Arrane
            TeamResultsSummary team1 = new TeamResultsSummary();
            TeamResultsSummary team2 = new TeamResultsSummary();
            TeamResultsSummaryComparator comparator = new TeamResultsSummaryComparator();

            team1.Points = 3;
            team2.Points = 0;

            //Act
            int comparisonResult = comparator.Compare(team1, team2);

            //Assert
            Assert.AreEqual(1, comparisonResult);
        }
    }
}
