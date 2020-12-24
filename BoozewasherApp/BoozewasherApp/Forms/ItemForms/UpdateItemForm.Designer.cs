
namespace BoozewasherApp.Forms.ItemForms
{
    partial class UpdateItemForm
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
            this.txtboxExpense = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxUsageCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboIsEmpty = new System.Windows.Forms.ComboBox();
            this.lblIsEmpty = new System.Windows.Forms.Label();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxExpense
            // 
            this.txtboxExpense.Location = new System.Drawing.Point(106, 144);
            this.txtboxExpense.Name = "txtboxExpense";
            this.txtboxExpense.Size = new System.Drawing.Size(275, 20);
            this.txtboxExpense.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Expense.............";
            // 
            // txtboxUsageCount
            // 
            this.txtboxUsageCount.Location = new System.Drawing.Point(106, 118);
            this.txtboxUsageCount.Name = "txtboxUsageCount";
            this.txtboxUsageCount.Size = new System.Drawing.Size(275, 20);
            this.txtboxUsageCount.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Usage Count.............";
            // 
            // comboIsEmpty
            // 
            this.comboIsEmpty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIsEmpty.FormattingEnabled = true;
            this.comboIsEmpty.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboIsEmpty.Location = new System.Drawing.Point(106, 91);
            this.comboIsEmpty.Name = "comboIsEmpty";
            this.comboIsEmpty.Size = new System.Drawing.Size(275, 21);
            this.comboIsEmpty.TabIndex = 35;
            // 
            // lblIsEmpty
            // 
            this.lblIsEmpty.AutoSize = true;
            this.lblIsEmpty.Location = new System.Drawing.Point(21, 94);
            this.lblIsEmpty.Name = "lblIsEmpty";
            this.lblIsEmpty.Size = new System.Drawing.Size(92, 13);
            this.lblIsEmpty.TabIndex = 34;
            this.lblIsEmpty.Text = "Is Empty?.............";
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Location = new System.Drawing.Point(106, 39);
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(275, 20);
            this.txtboxDescription.TabIndex = 29;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(106, 13);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(275, 20);
            this.txtboxName.TabIndex = 27;
            // 
            // txtboxBarcode
            // 
            this.txtboxBarcode.Location = new System.Drawing.Point(106, 65);
            this.txtboxBarcode.Name = "txtboxBarcode";
            this.txtboxBarcode.Size = new System.Drawing.Size(275, 20);
            this.txtboxBarcode.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Barcode.............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Description..........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name...................";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(281, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AllowUserToResizeColumns = false;
            this.dgvItem.AllowUserToResizeRows = false;
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItem.Location = new System.Drawing.Point(0, 219);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(401, 252);
            this.dgvItem.TabIndex = 26;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            // 
            // UpdateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 471);
            this.Controls.Add(this.txtboxExpense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxUsageCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboIsEmpty);
            this.Controls.Add(this.lblIsEmpty);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.txtboxBarcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvItem);
            this.Name = "UpdateItemForm";
            this.Text = "UpdateItemForm";
            this.Load += new System.EventHandler(this.UpdateItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxExpense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxUsageCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboIsEmpty;
        private System.Windows.Forms.Label lblIsEmpty;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvItem;
    }
}