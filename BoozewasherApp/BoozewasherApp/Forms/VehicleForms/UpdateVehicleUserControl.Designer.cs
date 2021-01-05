
namespace BoozewasherApp.Forms.VehicleForms
{
    partial class UpdateVehicleUserControl
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
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtboxModel = new System.Windows.Forms.TextBox();
            this.txtboxBrand = new System.Windows.Forms.TextBox();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(445, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 25);
            this.label15.TabIndex = 49;
            this.label15.Text = "Update Vehicles";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.txtboxType);
            this.panel7.Controls.Add(this.btnUpdate);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.txtboxDescription);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.txtboxModel);
            this.panel7.Controls.Add(this.txtboxBrand);
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
            this.btnUpdate.Location = new System.Drawing.Point(573, 119);
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
            // txtboxDescription
            // 
            this.txtboxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxDescription.BackColor = System.Drawing.Color.White;
            this.txtboxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxDescription.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDescription.Location = new System.Drawing.Point(398, 95);
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(275, 18);
            this.txtboxDescription.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(350, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Brand";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(318, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Description";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(346, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 32;
            this.label12.Text = "Model";
            // 
            // txtboxModel
            // 
            this.txtboxModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxModel.BackColor = System.Drawing.Color.White;
            this.txtboxModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxModel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxModel.Location = new System.Drawing.Point(398, 71);
            this.txtboxModel.Name = "txtboxModel";
            this.txtboxModel.Size = new System.Drawing.Size(275, 18);
            this.txtboxModel.TabIndex = 27;
            // 
            // txtboxBrand
            // 
            this.txtboxBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxBrand.BackColor = System.Drawing.Color.White;
            this.txtboxBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxBrand.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxBrand.Location = new System.Drawing.Point(398, 47);
            this.txtboxBrand.Name = "txtboxBrand";
            this.txtboxBrand.Size = new System.Drawing.Size(275, 18);
            this.txtboxBrand.TabIndex = 28;
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeColumns = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVehicles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVehicles.Location = new System.Drawing.Point(0, 248);
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVehicles.RowHeadersVisible = false;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(983, 294);
            this.dgvVehicles.TabIndex = 47;
            this.dgvVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicles_CellClick);
            // 
            // UpdateVehicleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dgvVehicles);
            this.Name = "UpdateVehicleUserControl";
            this.Size = new System.Drawing.Size(983, 542);
            this.Load += new System.EventHandler(this.UpdateVehicleUserControl_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtboxType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtboxModel;
        private System.Windows.Forms.TextBox txtboxBrand;
        private System.Windows.Forms.DataGridView dgvVehicles;
    }
}
