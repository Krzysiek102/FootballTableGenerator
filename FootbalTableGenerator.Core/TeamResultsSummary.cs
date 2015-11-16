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
        public string Team { get; set; }
        public int Points { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsLost { get; set; }

        public TeamResultsSummary()
        {
            Points = 0;
            GoalsScored = 0;
            GoalsLost = 0;
        }

        public int GoalDifference
        {
            get { return GoalsScored - GoalsLost; }
        }
    }
}
