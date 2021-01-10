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
        private int SelectedItemId { get; set; }
        public DeleteItemUserControl()
        {
            InitializeComponent();
        }

        private void DeleteItemUserControl_Load(object sender, EventArgs e)
        {
            //LoadDgvItems();
        }
        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedItemId = (int)dgvItems.SelectedRows[0].Cells[0].Value;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
            LoadDgvItems();
        }

        #region Private/public Methods
        private void DeleteItem()
        {
            mainForm.ItemRepository.DeleteItem(SelectedItemId);
        }
        public void LoadDgvItems()
        {
            dgvItems.DataSource = mainForm.ItemRepository.GetAllItems();
        }

        #endregion
        

        
    }
}
