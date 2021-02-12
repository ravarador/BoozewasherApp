using BoozewasherDomain.Entities;
using BoozewasherDomain.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Forms.AttendanceForms
{
    public partial class TimeInOutForm : Form
    {
        public MainForm mainForm { get; set; }
        public TimeInOutForm()
        {
            InitializeComponent();
        }
        private void TimeInOutForm_Load(object sender, EventArgs e)
        {
            var employees = mainForm.EmployeeRepository.GetEmployeesByBranchId(mainForm.UserInformation.BranchId);
            foreach (var employee in employees)
            {
                comboEmployees.Items.Add($"{employee.Id} - {employee.FirstName} {employee.MiddleName} {employee.LastName}");
            }
        }
        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            TimeIn();
            mainForm.LoadPresentEmployeeFlowLayoutPanel();
        }
        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            TimeOut();
            mainForm.LoadPresentEmployeeFlowLayoutPanel();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Private/public methods
        private void TimeIn()
        {
            var selectedEmployeeId = GetEmployeeIdFromComboBox();

            var attendanceToday = mainForm.AttendanceRepository.GetAttendancesByDate().Where(a => a.EmployeeId == selectedEmployeeId &&
                                                                                                  a.TimeInDate.Date == DateTime.Now.Date &&
                                                                                                  a.TimeOutDate == null);

            if (attendanceToday.Any())
            {
                MessageBox.Show("There is a pending time in!");
            }
            else
            {
                var attendance = new Attendance()
                {
                    EmployeeId = selectedEmployeeId,
                    TimeInDate = DateTime.Now,
                };
                mainForm.AttendanceRepository.TimeInEmployee(attendance);
                MessageBox.Show("Time in successful!");
            }
        }
        private void TimeOut()
        {
            var selectedEmployeeId = GetEmployeeIdFromComboBox();

            var attendanceToday = mainForm.AttendanceRepository.GetAttendancesByDate().Where(a => a.EmployeeId == selectedEmployeeId &&
                                                                                                  a.TimeInDate.Date == DateTime.Now.Date &&
                                                                                                  a.TimeOutDate == null);

            if (attendanceToday.Any())
            {
                var attendance = new Attendance()
                {
                    Id = attendanceToday.SingleOrDefault().Id,
                    EmployeeId = selectedEmployeeId,
                    TimeOutDate = DateTime.Now
                };
                mainForm.AttendanceRepository.TimeOutEmployee(attendance);
                MessageBox.Show("Time out successful!");

            }
            else
            {
                MessageBox.Show("No pending time in!");
            }
        }
        private int GetEmployeeIdFromComboBox()
        {
            var selectedEmployee = comboEmployees.SelectedItem.ToString();
            var branchId = selectedEmployee.Split('-')[0].Trim();
            return int.Parse(branchId);
        }

        #endregion

        
    }
}
