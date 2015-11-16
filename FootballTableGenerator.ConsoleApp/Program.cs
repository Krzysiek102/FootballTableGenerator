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
            Table table = new Table();
            while (true)
            {
                string result = Console.ReadLine();
                table.RegisterMatch(result);
                Console.Write(table.Visualize());
                Console.WriteLine();
            }
        }
    }
}
