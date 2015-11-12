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
        public void Euro2016QualifiersPolandIrelandGermany()
        {
            Table table = new Table();

            table.RegisterMatch("Poland - Germany 2:0");
            table.RegisterMatch("Germany - Ireland 1:1");
            table.RegisterMatch("Ireland - Poland 1:1");
            table.RegisterMatch("Germany - Poland 3:1");
            table.RegisterMatch("Ireland - Germany 1:0");
            table.RegisterMatch("Poland - Ireland 2:1");

            string visualizedTable = table.Visualize();

            string expectedTable =
@"1. Poland 7 6:5 1
2. Ireland 5 4:4 0
3. Germany 4 4:5 -1";
            
            Assert.That(visualizedTable == expectedTable);
        }
    }
}
