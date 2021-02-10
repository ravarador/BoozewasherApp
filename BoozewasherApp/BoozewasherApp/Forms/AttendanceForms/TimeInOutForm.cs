﻿using BoozewasherDomain.Entities;
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
            var selectedEmployeeId = GetEmployeeIdFromComboBox();

            var attendanceToday = mainForm.AttendanceRepository.GetAttendancesByDate();

            if (attendanceToday.Where(a => a.EmployeeId == selectedEmployeeId && a.TimeInDate.Date == DateTime.Now.Date).Any())
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
        private void btnTimeOut_Click(object sender, EventArgs e)
        {

        }
        private int GetEmployeeIdFromComboBox()
        {
            var selectedEmployee = comboEmployees.SelectedItem.ToString();
            var branchId = selectedEmployee.Split('-')[0].Trim();
            return int.Parse(branchId);
        }

        
    }
}
