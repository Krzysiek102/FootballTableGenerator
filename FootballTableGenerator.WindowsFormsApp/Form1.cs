using FootbalTableGenerator.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballTableGenerator.WindowsFormsApp
{
    public partial class FootbalTableGenerator : Form
    {
        private Table table;
        private MatchBuilder mrb = new MatchBuilder();

        public FootbalTableGenerator()
        {
            InitializeComponent();
            table = new Table();
        }

        private void uxRegisterResult_Click(object sender, EventArgs e)
        {
            string result = uxInputResult.Text;
            table.RegisterMatch(result);
            uxTable.Text = table.ToString();
        }
    }
}
