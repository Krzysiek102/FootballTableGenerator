﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootbalTableGenerator.Core
{
    public class TeamInTable
    {
        public uint Position { get; set; }
        public TeamResultsSummary FootbalTeamResultsSummary { get; set; }
    }
}
