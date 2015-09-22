using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core
{
    public class TeamResultsSummary
    {
        public Team Team { get; set; }
        public uint Points { get; set; }
        public uint GoalsScored { get; set; }
        public uint GoalsLost { get; set; }

        public TeamResultsSummary()
        {
            Points = 0;
            GoalsScored = 0;
            GoalsLost = 0;
        }

        public int GoalDifference
        {
            get { return (int) (GoalsScored - GoalsLost); }
        }
    }
}
