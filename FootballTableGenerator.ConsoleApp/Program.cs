using FootbalTableGenerator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTableGenerator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table(new TeamResultsSummaryComparator());
            MatchResultsBuilder mrb = new MatchResultsBuilder();
            while (true)
            {
                string result = Console.ReadLine();
                table.RegisterMatch(mrb.ConstructMatch(result));
                Console.Write(table.ToString());
            }
        }
    }
}
