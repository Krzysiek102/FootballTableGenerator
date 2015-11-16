using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core.Tests
{
    [TestFixture]
    public class MatchBuilderTests
    {
        [Test]
        public void OneWordForTeamAnOneDigitForResultShouldGiveCorrectMatch()
        {
            MatchBuilder matchBuilder = new MatchBuilder();
            FootballMatch matchResult = matchBuilder.ConstructMatch("Poland - Germany 2:0");

            Assert.AreEqual(matchResult.HostTeam, "Poland");
            Assert.AreEqual(matchResult.GuestTeam, "Germany");
            Assert.AreEqual(matchResult.NumberOfGoalsScoredByHosts, 2);
            Assert.AreEqual(matchResult.NumberOfGoalsScoredByGuests, 0);
        }
    }
}
