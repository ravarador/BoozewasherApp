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

namespace BoozewasherApp.Forms.ItemForms
{
    public partial class DeleteItemForm : Form
    {
        private IItemRepository ItemRepository { get; set; }
        private int SelectedItemId { get; set; }
        public DeleteItemForm(IItemRepository itemRepository)
        {
            InitializeComponent();
            ItemRepository = itemRepository;
        }

        private void DeleteItemForm_Load(object sender, EventArgs e)
        {
            SetLabelsToEmpty();
            LoadDgvItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemRepository.DeleteItem(SelectedItemId);

            SetLabelsToEmpty();
            LoadDgvItem();
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedItemId = (int)dgvItem.SelectedRows[0].Cells[0].Value;

            lblName.Text = dgvItem.SelectedRows[0].Cells[1].Value.ToString();
            lblDescription.Text = dgvItem.SelectedRows[0].Cells[2].Value.ToString();
            lblBarcode.Text = dgvItem.SelectedRows[0].Cells[3].Value.ToString();
            lblIsEmpty.Text = dgvItem.SelectedRows[0].Cells[4].Value.ToString();
            lblUsageCount.Text = dgvItem.SelectedRows[0].Cells[5].Value.ToString();
            lblExpense.Text = dgvItem.SelectedRows[0].Cells[6].Value.ToString();
        }

        #region Private Methods
        private void LoadDgvItem()
        {
            dgvItem.DataSource = ItemRepository.GetAllItems();
        }

        private void SetLabelsToEmpty()
        {
            lblBarcode.Text = string.Empty;
            lblDescription.Text = string.Empty;
            lblExpense.Text = string.Empty;
            lblIsEmpty.Text = string.Empty;
            lblName.Text = string.Empty;
            lblUsageCount.Text = string.Empty;
        }
        #endregion
    }
}
