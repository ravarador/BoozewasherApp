using BoozewasherDomain.Entities;
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
    public partial class PresentEmployeeUserControl : UserControl
    {
        private int _id;
        private DateTime _timeInTime;
        private string _name;
        public MainForm mainForm;
        public PresentEmployeeUserControl(int id, DateTime timeInTime, string name)
        {
            InitializeComponent();
            _id = id;
            _timeInTime = timeInTime;
            _name = name;

            LoadLabels();
        }
        private void LoadLabels()
        {
            lblId.Text = _id.ToString();
            lblTimeInTime.Text = _timeInTime.ToString("hh:mm tt");
            lblName.Text = _name;
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            TimeOut();
            mainForm.LoadPresentEmployeeFlowLayoutPanel();
        }
        private void TimeOut()
        {
            var selectedEmployeeId = _id;

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
    }
}
