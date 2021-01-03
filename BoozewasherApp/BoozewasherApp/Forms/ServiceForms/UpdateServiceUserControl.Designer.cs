
namespace BoozewasherApp.Forms.ServiceForms
{
    partial class UpdateServiceUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtboxType = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.txtboxExpense = new System.Windows.Forms.TextBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(445, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 25);
            this.label15.TabIndex = 49;
            this.label15.Text = "Update Services";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.txtboxType);
            this.panel7.Controls.Add(this.btnUpdate);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.txtboxDescription);
            this.panel7.Controls.Add(this.txtboxExpense);
            this.panel7.Location = new System.Drawing.Point(0, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(983, 214);
            this.panel7.TabIndex = 48;
            // 
            // txtboxType
            // 
            this.txtboxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxType.BackColor = System.Drawing.Color.White;
            this.txtboxType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxType.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxType.Location = new System.Drawing.Point(398, 23);
            this.txtboxType.Name = "txtboxType";
            this.txtboxType.Size = new System.Drawing.Size(275, 18);
            this.txtboxType.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(573, 95);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(356, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Type";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(336, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Expense";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(318, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Description";
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxDescription.BackColor = System.Drawing.Color.White;
            this.txtboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxDescription.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDescription.Location = new System.Drawing.Point(398, 71);
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(275, 18);
            this.txtboxDescription.TabIndex = 27;
            // 
            // txtboxExpense
            // 
            this.txtboxExpense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxExpense.BackColor = System.Drawing.Color.White;
            this.txtboxExpense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxExpense.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxExpense.Location = new System.Drawing.Point(398, 47);
            this.txtboxExpense.Name = "txtboxExpense";
            this.txtboxExpense.Size = new System.Drawing.Size(275, 18);
            this.txtboxExpense.TabIndex = 28;
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvServices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvServices.Location = new System.Drawing.Point(0, 248);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(983, 294);
            this.dgvServices.TabIndex = 47;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            // 
            // UpdateServiceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dgvServices);
            this.Name = "UpdateServiceUserControl";
            this.Size = new System.Drawing.Size(983, 542);
            this.Load += new System.EventHandler(this.UpdateServiceUserControl_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtboxType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.TextBox txtboxExpense;
        private System.Windows.Forms.DataGridView dgvServices;
    }
}
