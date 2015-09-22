using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core
{
    public class MatchResult
    {
        public Team HostTeam { get; set; }
        public Team GuestTeam { get; set; }
        public byte NumberOfGoalsScoredByHosts { get; set; }
        public byte NumberOfGoalsScoredByGuests { get; set; }
    }
}
