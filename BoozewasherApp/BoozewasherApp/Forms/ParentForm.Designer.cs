namespace BoozewasherApp
{
    partial class ParentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceToolStripMenuItem,
            this.vehicleToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.summaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateServiceToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // updateServiceToolStripMenuItem
            // 
            this.updateServiceToolStripMenuItem.Name = "updateServiceToolStripMenuItem";
            this.updateServiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateServiceToolStripMenuItem.Text = "Update Service";
            this.updateServiceToolStripMenuItem.Click += new System.EventHandler(this.updateServiceToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.updateVehicleToolStripMenuItem,
            this.deleteVehicleToolStripMenuItem});
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.addVehicleToolStripMenuItem_Click);
            // 
            // updateVehicleToolStripMenuItem
            // 
            this.updateVehicleToolStripMenuItem.Name = "updateVehicleToolStripMenuItem";
            this.updateVehicleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateVehicleToolStripMenuItem.Text = "Update Vehicle";
            this.updateVehicleToolStripMenuItem.Click += new System.EventHandler(this.updateVehicleToolStripMenuItem_Click);
            // 
            // deleteVehicleToolStripMenuItem
            // 
            this.deleteVehicleToolStripMenuItem.Name = "deleteVehicleToolStripMenuItem";
            this.deleteVehicleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteVehicleToolStripMenuItem.Text = "Delete Vehicle";
            this.deleteVehicleToolStripMenuItem.Click += new System.EventHandler(this.deleteVehicleToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem,
            this.updateTransactionToolStripMenuItem,
            this.deleteTransactionToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // addTransactionToolStripMenuItem
            // 
            this.addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            this.addTransactionToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addTransactionToolStripMenuItem.Text = "Add Transaction";
            this.addTransactionToolStripMenuItem.Click += new System.EventHandler(this.addTransactionToolStripMenuItem_Click);
            // 
            // updateTransactionToolStripMenuItem
            // 
            this.updateTransactionToolStripMenuItem.Name = "updateTransactionToolStripMenuItem";
            this.updateTransactionToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.updateTransactionToolStripMenuItem.Text = "Update Transaction";
            this.updateTransactionToolStripMenuItem.Click += new System.EventHandler(this.updateTransactionToolStripMenuItem_Click);
            // 
            // deleteTransactionToolStripMenuItem
            // 
            this.deleteTransactionToolStripMenuItem.Name = "deleteTransactionToolStripMenuItem";
            this.deleteTransactionToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteTransactionToolStripMenuItem.Text = "Delete Transaction";
            this.deleteTransactionToolStripMenuItem.Click += new System.EventHandler(this.deleteTransactionToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportToolStripMenuItem});
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.summaryToolStripMenuItem.Text = "Summary";
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.generateReportToolStripMenuItem.Text = "Generate Report";
            this.generateReportToolStripMenuItem.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoozeWasher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
    }
}

