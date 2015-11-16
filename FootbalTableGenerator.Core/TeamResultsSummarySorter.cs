﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core
{
    public class TeamResultsSummarySorter
    {
        private readonly IComparer<TeamResultsSummary> teamComparator = new TeamResultsSummaryComparator();

        public IEnumerable<TeamInTable> Sort(List<TeamResultsSummary> teamsResults)
        {
            teamsResults.Sort(teamComparator);
            teamsResults.Reverse();
            uint currentPosition = 1;
            List<TeamInTable> table = new List<TeamInTable>();
            foreach (TeamResultsSummary teamResultsSummary in teamsResults)
            {
                TeamInTable teamInTable = new TeamInTable();
                teamInTable.FootbalTeamResultsSummary = teamResultsSummary;
                teamInTable.Position = currentPosition;
                table.Add(teamInTable);
                currentPosition++;
            }
            return table;
        }
    }
}
