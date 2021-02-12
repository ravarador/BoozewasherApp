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
            var presentEmployeeUserControl = new PresentEmployeeUserControl(1, DateTime.Now, "TEST");
            presentEmployeeUserControl.mainForm = mainForm;

            presentEmployeesFlowLayoutPanel.Controls.Add(presentEmployeeUserControl);
        }
        private void timerForClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        public void LoadClock()
        {
            timerForClock.Start();
        }
        public void LoadPresentEmployeeFlowLayoutPanel()
        {
            presentEmployeesFlowLayoutPanel.Controls.Clear();

            var presentEmployees = mainForm.AttendanceRepository.GetAttendancesByDate().Where(a => a.TimeInDate.Date == DateTime.Now.Date &&
                                                                                                   a.TimeOutDate == null);
            lblPresentEmployees.Text = presentEmployees.Count().ToString();

            foreach (var employee in presentEmployees)
            {
                var presentEmployeeUserControl = new PresentEmployeeUserControl(employee.EmployeeId, 
                                                                                employee.TimeInDate, 
                                                                                $"{employee.Employee.FirstName} {employee.Employee.MiddleName} {employee.Employee.LastName}");
                presentEmployeeUserControl.mainForm = mainForm;

                presentEmployeesFlowLayoutPanel.Controls.Add(presentEmployeeUserControl);
            }
        }

        
    }
}
