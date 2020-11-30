namespace BoozewasherApp.Forms.ServiceForms
{
    partial class AddServiceForm
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
            this.txtboxType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxExpense = new System.Windows.Forms.TextBox();
            this.dgvService = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxType
            // 
            this.txtboxType.Location = new System.Drawing.Point(116, 43);
            this.txtboxType.Name = "txtboxType";
            this.txtboxType.Size = new System.Drawing.Size(275, 20);
            this.txtboxType.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(291, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Location = new System.Drawing.Point(116, 95);
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(275, 20);
            this.txtboxDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type...................";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description..........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expense.............";
            // 
            // txtboxExpense
            // 
            this.txtboxExpense.Location = new System.Drawing.Point(116, 69);
            this.txtboxExpense.Name = "txtboxExpense";
            this.txtboxExpense.Size = new System.Drawing.Size(275, 20);
            this.txtboxExpense.TabIndex = 6;
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.AllowUserToResizeColumns = false;
            this.dgvService.AllowUserToResizeRows = false;
            this.dgvService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvService.Location = new System.Drawing.Point(0, 166);
            this.dgvService.Name = "dgvService";
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvService.Size = new System.Drawing.Size(461, 259);
            this.dgvService.TabIndex = 7;
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 425);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.txtboxType);
            this.Controls.Add(this.txtboxExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Service";
            this.Load += new System.EventHandler(this.AddServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxExpense;
        private System.Windows.Forms.DataGridView dgvService;
    }
}