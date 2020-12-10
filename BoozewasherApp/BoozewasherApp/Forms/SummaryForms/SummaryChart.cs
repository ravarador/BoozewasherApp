using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Forms.SummaryForms
{
    public partial class SummaryChart : Form
    {
        public SummaryChart()
        {
            InitializeComponent();
        }

        private void radSelectDate_Click(object sender, EventArgs e)
        {
            if (radSelectDate.Checked)
            {
                grpboxDate.Enabled = true;
                grpboxDateRange.Enabled = false;
            }
            else if (radSelectDateRange.Checked)
            {
                grpboxDate.Enabled = false;
                grpboxDateRange.Enabled = true;
            }
        }
    }
}
