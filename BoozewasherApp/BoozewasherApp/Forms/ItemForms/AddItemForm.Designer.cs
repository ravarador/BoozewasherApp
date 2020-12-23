
namespace BoozewasherApp.Forms.ItemForms
{
    partial class AddItemForm
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
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.dgvItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvItem.Location = new System.Drawing.Point(0, 249);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(423, 252);
            this.dgvItem.TabIndex = 12;
            // 
            // txtboxExpense
            // 
            this.txtboxExpense.Location = new System.Drawing.Point(106, 156);
            this.txtboxExpense.Name = "txtboxExpense";
            this.txtboxExpense.Size = new System.Drawing.Size(275, 20);
            this.txtboxExpense.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Expense.............";
            // 
            // txtboxUsageCount
            // 
            this.txtboxUsageCount.Location = new System.Drawing.Point(106, 130);
            this.txtboxUsageCount.Name = "txtboxUsageCount";
            this.txtboxUsageCount.Size = new System.Drawing.Size(275, 20);
            this.txtboxUsageCount.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Usage Count.............";
            // 
            // comboIsEmpty
            // 
            this.comboIsEmpty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIsEmpty.FormattingEnabled = true;
            this.comboIsEmpty.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboIsEmpty.Location = new System.Drawing.Point(106, 103);
            this.comboIsEmpty.Name = "comboIsEmpty";
            this.comboIsEmpty.Size = new System.Drawing.Size(275, 21);
            this.comboIsEmpty.TabIndex = 21;
            // 
            // lblIsEmpty
            // 
            this.lblIsEmpty.AutoSize = true;
            this.lblIsEmpty.Location = new System.Drawing.Point(21, 106);
            this.lblIsEmpty.Name = "lblIsEmpty";
            this.lblIsEmpty.Size = new System.Drawing.Size(92, 13);
            this.lblIsEmpty.TabIndex = 20;
            this.lblIsEmpty.Text = "Is Empty?.............";
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Location = new System.Drawing.Point(106, 51);
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(275, 20);
            this.txtboxDescription.TabIndex = 15;
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(106, 25);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(275, 20);
            this.txtboxName.TabIndex = 13;
            // 
            // txtboxBarcode
            // 
            this.txtboxBarcode.Location = new System.Drawing.Point(106, 77);
            this.txtboxBarcode.Name = "txtboxBarcode";
            this.txtboxBarcode.Size = new System.Drawing.Size(275, 20);
            this.txtboxBarcode.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Barcode.............";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description..........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name...................";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(281, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 501);
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
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvItem);
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItem;
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
        private System.Windows.Forms.Button btnAdd;
    }
}