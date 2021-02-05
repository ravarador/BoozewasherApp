using BoozewasherDomain.Dtos;
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
        private int? SelectedItemId { get; set; }
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
            if (SelectedItemId != null)
            {
                DeleteItem();
                LoadDgvItems();
            }
            else
            {
                MessageBox.Show("Select an item to delete!", "Error");
            }
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboSearchBy.SelectedItem != null)
            {
                SearchItems();
            }
            else
            {
                MessageBox.Show("Search By must not be empty.");
            }

        }
        #region Private/public Methods
        private void SearchItems()
        {
            var items = mainForm.ItemRepository.GetItemsBySearchParameter(new SearchDto
            {
                BranchId = mainForm.UserInformation.BranchId,
                SearchBy = comboSearchBy.SelectedItem.ToString(),
                SearchText = txtboxSearchText.Text
            });

            dgvItems.DataSource = items;
        }
        private void DeleteItem()
        {
            mainForm.ItemRepository.DeleteItem(SelectedItemId.Value);
            SelectedItemId = null;
        }
        public void LoadDgvItems()
        {
            dgvItems.DataSource = mainForm.ItemRepository.GetItemsByBranchId(mainForm.UserInformation.BranchId);
        }



        #endregion

        
    }
}
