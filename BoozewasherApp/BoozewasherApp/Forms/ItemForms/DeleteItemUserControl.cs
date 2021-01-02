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
    public partial class DeleteItemUserControl : UserControl
    {
        public MainForm mainForm;
        public DeleteItemUserControl()
        {
            InitializeComponent();
        }

        private void DeleteItemUserControl_Load(object sender, EventArgs e)
        {

        }

        #region Private Methods
        private void LoadDgvItem()
        {
            dgvItems.DataSource = mainForm.ItemRepository.GetAllItems();
        }

        #endregion
    }
}
