using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core.Tests
{
    [TestFixture]
    public class TableTests
    {
        [Test]
        public void WorldCup2014GroupA()
        {
            Table table = new Table(new TeamResultsSummaryComparator());
            MatchResultsBuilder mrb = new MatchResultsBuilder();
            table.RegisterMatch(mrb.ConstructMatch("Brasil - Croatia 3:1"));
            table.RegisterMatch(mrb.ConstructMatch("Mexico - Cameroon 1:0"));
            table.RegisterMatch(mrb.ConstructMatch("Brasil - Mexico 0:0"));
            table.RegisterMatch(mrb.ConstructMatch("Croatia - Cameroon 4:0"));
            table.RegisterMatch(mrb.ConstructMatch("Brasil - Cameroon 4:1"));
            table.RegisterMatch(mrb.ConstructMatch("Mexico - Croatia 3:1"));

            List<TeamInTable> results = table.GetCurrentTable().ToList();

            Assert.That(results.Count == 4);

            Assert.That(results[0].Position == 1);
            Assert.That(results[0].FootbalTeamResultsSummary.Team.Name == "Brasil");
            Assert.That(results[0].FootbalTeamResultsSummary.Points == 7);
            Assert.That(results[0].FootbalTeamResultsSummary.GoalsScored == 7);
            Assert.That(results[0].FootbalTeamResultsSummary.GoalsLost == 2);

            Assert.That(results[1].Position == 2);
            Assert.That(results[1].FootbalTeamResultsSummary.Team.Name == "Mexico");
            Assert.That(results[1].FootbalTeamResultsSummary.Points == 7);
            Assert.That(results[1].FootbalTeamResultsSummary.GoalsScored == 4);
            Assert.That(results[1].FootbalTeamResultsSummary.GoalsLost == 1);

            Assert.That(results[2].Position == 3);
            Assert.That(results[2].FootbalTeamResultsSummary.Team.Name == "Croatia");
            Assert.That(results[2].FootbalTeamResultsSummary.Points == 3);
            Assert.That(results[2].FootbalTeamResultsSummary.GoalsScored == 6);
            Assert.That(results[2].FootbalTeamResultsSummary.Points == 3);

            Assert.That(results[3].Position == 4);
            Assert.That(results[3].FootbalTeamResultsSummary.Team.Name == "Cameroon");
            Assert.That(results[3].FootbalTeamResultsSummary.Points == 0);
            Assert.That(results[3].FootbalTeamResultsSummary.GoalsScored == 1);
            Assert.That(results[3].FootbalTeamResultsSummary.GoalsLost == 9);
        }
    }
}
