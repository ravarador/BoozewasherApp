using BoozewasherApp.Forms.AttendanceForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Forms.EmployeeForms
{
    public partial class EmployeeHomeUserControl : UserControl
    {
        public MainForm mainForm;
        public EmployeeHomeUserControl()
        {
            InitializeComponent();
        }

        private void btnTimeInOut_Click(object sender, EventArgs e)
        {
            var timeInTimeOutForm = new TimeInOutForm();
            timeInTimeOutForm.mainForm = mainForm;
            timeInTimeOutForm.ShowDialog();
        }
    }
}
