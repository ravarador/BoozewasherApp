using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoozewasherApp.Forms.ItemForms
{
    public partial class AddItemUserControl : UserControl
    {
        public MainForm mainForm { get; set; }
        public AddItemUserControl()
        {
            InitializeComponent();
        }

        private void AddItemUserControl_Load(object sender, EventArgs e)
        {
            dgvItems.DataSource = mainForm.ItemRepository.GetAllItems();
        }
    }
}
