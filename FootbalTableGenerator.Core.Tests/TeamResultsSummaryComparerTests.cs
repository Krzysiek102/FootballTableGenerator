using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core.Tests
{
    [TestFixture]
    public class TeamResultsSummaryComparerTests
    {
        [Test]
        public void TeamWithLargerNumberOfPointsShouldBeGreater()
        {
            //Arrane
            TeamResultsSummaryComparer comparer = new TeamResultsSummaryComparer();

            TeamResultsSummary team1 = new TeamResultsSummary() { Points = 3 };
            TeamResultsSummary team2 = new TeamResultsSummary() { Points = 0 };

            //Act
            int comparisonResult = comparer.Compare(team1, team2);

            //Assert
            Assert.AreEqual(1, comparisonResult);
        }
    }
}
