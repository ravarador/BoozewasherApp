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

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            var presentEmployeeUserControl = new PresentEmployeeUserControl();
            presentEmployeesFlowLayoutPanel.Controls.Add(presentEmployeeUserControl);
        }

        public void LoadPresentEmployeeFlowLayoutPanel()
        {
            var presentEmployees = mainForm.AttendanceRepository.GetAttendancesByDate().Where(a => a.TimeInDate.Date == DateTime.Now.Date &&
                                                                                                   a.TimeOutDate == null);

            foreach (var employee in presentEmployees)
            {

            }
        }
    }
}
