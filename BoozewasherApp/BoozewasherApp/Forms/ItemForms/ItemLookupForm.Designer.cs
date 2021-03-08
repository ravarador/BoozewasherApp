﻿
namespace BoozewasherApp.Forms.ItemForms
{
    partial class ItemLookupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.comboOrderBy = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxOrderBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItem.Location = new System.Drawing.Point(0, 83);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(541, 535);
            this.dgvItem.TabIndex = 1;
            this.dgvItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellDoubleClick);
            // 
            // comboOrderBy
            // 
            this.comboOrderBy.FormattingEnabled = true;
            this.comboOrderBy.Location = new System.Drawing.Point(66, 40);
            this.comboOrderBy.Name = "comboOrderBy";
            this.comboOrderBy.Size = new System.Drawing.Size(161, 21);
            this.comboOrderBy.TabIndex = 23;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(383, 39);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(101, 23);
            this.btnSort.TabIndex = 21;
            this.btnSort.Text = "Sort Items";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Order by: ";
            // 
            // txtboxOrderBy
            // 
            this.txtboxOrderBy.Location = new System.Drawing.Point(233, 41);
            this.txtboxOrderBy.Name = "txtboxOrderBy";
            this.txtboxOrderBy.Size = new System.Drawing.Size(144, 20);
            this.txtboxOrderBy.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search by";
            // 
            // ItemLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboOrderBy);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxOrderBy);
            this.Controls.Add(this.dgvItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ItemLookupForm";
            this.Text = "Item Lookup Form";
            this.Load += new System.EventHandler(this.ItemLookupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.ComboBox comboOrderBy;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxOrderBy;
        private System.Windows.Forms.Label label1;
    }
}