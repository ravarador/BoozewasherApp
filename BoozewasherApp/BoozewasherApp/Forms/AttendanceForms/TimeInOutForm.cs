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
                comboEmployees.Items.Add($"{employee.FirstName} {employee.LastName}");
            }
        }
        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            //var attendance = new Attendance()
            //{
                
            //}
        }

        
    }
}
