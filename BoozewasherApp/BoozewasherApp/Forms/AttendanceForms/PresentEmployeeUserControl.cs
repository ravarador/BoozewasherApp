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

    }
}
