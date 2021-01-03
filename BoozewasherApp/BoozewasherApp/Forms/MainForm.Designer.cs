namespace BoozewasherApp.Forms
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.picboxBooze = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.btnTransactionsView = new System.Windows.Forms.Button();
            this.btnTransactionsUpdate = new System.Windows.Forms.Button();
            this.btnTransactionsDelete = new System.Windows.Forms.Button();
            this.btnTransactionsAdd = new System.Windows.Forms.Button();
            this.panelItems = new System.Windows.Forms.Panel();
            this.btnItemsView = new System.Windows.Forms.Button();
            this.btnItemsUpdate = new System.Windows.Forms.Button();
            this.btnItemsDelete = new System.Windows.Forms.Button();
            this.btnItemsAdd = new System.Windows.Forms.Button();
            this.panelServices = new System.Windows.Forms.Panel();
            this.btnServicesView = new System.Windows.Forms.Button();
            this.btnServicesUpdate = new System.Windows.Forms.Button();
            this.btnServicesDelete = new System.Windows.Forms.Button();
            this.btnServicesAdd = new System.Windows.Forms.Button();
            this.panelVehicles = new System.Windows.Forms.Panel();
            this.btnVehiclesView = new System.Windows.Forms.Button();
            this.btnVehiclesUpdate = new System.Windows.Forms.Button();
            this.btnVehiclesDelete = new System.Windows.Forms.Button();
            this.btnVehiclesAdd = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.tabPageAnalytics = new System.Windows.Forms.TabPage();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.deleteItemUserControl1 = new BoozewasherApp.Forms.ItemForms.DeleteItemUserControl();
            this.addItemUserControl1 = new BoozewasherApp.Forms.ItemForms.AddItemUserControl();
            this.updateItemUserControl1 = new BoozewasherApp.Forms.ItemForms.UpdateItemUserControl();
            this.addServiceUserControl1 = new BoozewasherApp.Forms.ServiceForms.AddServiceUserControl();
            this.updateServiceUserControl1 = new BoozewasherApp.Forms.ServiceForms.UpdateServiceUserControl();
            this.deleteServiceUserControl1 = new BoozewasherApp.Forms.ServiceForms.DeleteServiceUserControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBooze)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageSales.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.panelServices.SuspendLayout();
            this.panelVehicles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "User: Ravni Arador | Logged In DateTime: 19/12/2020 11:15 PM";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BoozewasherApp.Properties.Resources.close_white_32x32;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1079, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 39);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnAnalytics);
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.btnEmployees);
            this.panel2.Controls.Add(this.btnSales);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1001, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 666);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "19/12/2020 11:16 PM";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.BackgroundImage = global::BoozewasherApp.Properties.Resources.settings_black_36x36;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(0, 435);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 87);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnalytics.BackgroundImage = global::BoozewasherApp.Properties.Resources.assessment_black_36x36;
            this.btnAnalytics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.Location = new System.Drawing.Point(0, 348);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(111, 87);
            this.btnAnalytics.TabIndex = 5;
            this.btnAnalytics.Text = "ANALYTICS";
            this.btnAnalytics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnalytics.UseVisualStyleBackColor = false;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReports.BackgroundImage = global::BoozewasherApp.Properties.Resources.picture_as_pdf_black_36x36;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(0, 261);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(111, 87);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "REPORTS";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmployees.BackgroundImage = global::BoozewasherApp.Properties.Resources.group_black_36x36;
            this.btnEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.Black;
            this.btnEmployees.Location = new System.Drawing.Point(0, 174);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(111, 87);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "EMPLOYEES";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSales.BackgroundImage = global::BoozewasherApp.Properties.Resources.local_car_wash_black_36x36;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(0, 87);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(111, 87);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "SALES";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.BackgroundImage = global::BoozewasherApp.Properties.Resources.home_black_36x36;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(111, 87);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picboxBooze
            // 
            this.picboxBooze.Image = global::BoozewasherApp.Properties.Resources.booze_logo;
            this.picboxBooze.InitialImage = null;
            this.picboxBooze.Location = new System.Drawing.Point(12, 12);
            this.picboxBooze.Name = "picboxBooze";
            this.picboxBooze.Size = new System.Drawing.Size(150, 87);
            this.picboxBooze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxBooze.TabIndex = 0;
            this.picboxBooze.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHome);
            this.tabControl1.Controls.Add(this.tabPageSales);
            this.tabControl1.Controls.Add(this.tabPageInventory);
            this.tabControl1.Controls.Add(this.tabPageReports);
            this.tabControl1.Controls.Add(this.tabPageAnalytics);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 712);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.White;
            this.tabPageHome.Location = new System.Drawing.Point(4, 23);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Size = new System.Drawing.Size(1104, 685);
            this.tabPageHome.TabIndex = 5;
            // 
            // tabPageSales
            // 
            this.tabPageSales.BackColor = System.Drawing.Color.White;
            this.tabPageSales.Controls.Add(this.panelTransactions);
            this.tabPageSales.Controls.Add(this.panelItems);
            this.tabPageSales.Controls.Add(this.panelServices);
            this.tabPageSales.Controls.Add(this.panelVehicles);
            this.tabPageSales.Controls.Add(this.btnItems);
            this.tabPageSales.Controls.Add(this.btnVehicles);
            this.tabPageSales.Controls.Add(this.btnServices);
            this.tabPageSales.Controls.Add(this.btnTransactions);
            this.tabPageSales.Controls.Add(this.deleteItemUserControl1);
            this.tabPageSales.Controls.Add(this.addItemUserControl1);
            this.tabPageSales.Controls.Add(this.updateItemUserControl1);
            this.tabPageSales.Controls.Add(this.addServiceUserControl1);
            this.tabPageSales.Controls.Add(this.updateServiceUserControl1);
            this.tabPageSales.Controls.Add(this.deleteServiceUserControl1);
            this.tabPageSales.Location = new System.Drawing.Point(4, 23);
            this.tabPageSales.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(1104, 685);
            this.tabPageSales.TabIndex = 0;
            // 
            // panelTransactions
            // 
            this.panelTransactions.Controls.Add(this.btnTransactionsView);
            this.panelTransactions.Controls.Add(this.btnTransactionsUpdate);
            this.panelTransactions.Controls.Add(this.btnTransactionsDelete);
            this.panelTransactions.Controls.Add(this.btnTransactionsAdd);
            this.panelTransactions.Location = new System.Drawing.Point(164, 75);
            this.panelTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(206, 208);
            this.panelTransactions.TabIndex = 9;
            this.panelTransactions.Visible = false;
            // 
            // btnTransactionsView
            // 
            this.btnTransactionsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnTransactionsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionsView.FlatAppearance.BorderSize = 0;
            this.btnTransactionsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionsView.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionsView.ForeColor = System.Drawing.Color.White;
            this.btnTransactionsView.Location = new System.Drawing.Point(0, 141);
            this.btnTransactionsView.Name = "btnTransactionsView";
            this.btnTransactionsView.Size = new System.Drawing.Size(206, 47);
            this.btnTransactionsView.TabIndex = 4;
            this.btnTransactionsView.Text = "View";
            this.btnTransactionsView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransactionsView.UseVisualStyleBackColor = false;
            // 
            // btnTransactionsUpdate
            // 
            this.btnTransactionsUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnTransactionsUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionsUpdate.FlatAppearance.BorderSize = 0;
            this.btnTransactionsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionsUpdate.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionsUpdate.ForeColor = System.Drawing.Color.White;
            this.btnTransactionsUpdate.Location = new System.Drawing.Point(0, 94);
            this.btnTransactionsUpdate.Name = "btnTransactionsUpdate";
            this.btnTransactionsUpdate.Size = new System.Drawing.Size(206, 47);
            this.btnTransactionsUpdate.TabIndex = 3;
            this.btnTransactionsUpdate.Text = "Update";
            this.btnTransactionsUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransactionsUpdate.UseVisualStyleBackColor = false;
            // 
            // btnTransactionsDelete
            // 
            this.btnTransactionsDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnTransactionsDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionsDelete.FlatAppearance.BorderSize = 0;
            this.btnTransactionsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionsDelete.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionsDelete.ForeColor = System.Drawing.Color.White;
            this.btnTransactionsDelete.Location = new System.Drawing.Point(0, 47);
            this.btnTransactionsDelete.Name = "btnTransactionsDelete";
            this.btnTransactionsDelete.Size = new System.Drawing.Size(206, 47);
            this.btnTransactionsDelete.TabIndex = 2;
            this.btnTransactionsDelete.Text = "Delete";
            this.btnTransactionsDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransactionsDelete.UseVisualStyleBackColor = false;
            // 
            // btnTransactionsAdd
            // 
            this.btnTransactionsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnTransactionsAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionsAdd.FlatAppearance.BorderSize = 0;
            this.btnTransactionsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionsAdd.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionsAdd.ForeColor = System.Drawing.Color.White;
            this.btnTransactionsAdd.Location = new System.Drawing.Point(0, 0);
            this.btnTransactionsAdd.Name = "btnTransactionsAdd";
            this.btnTransactionsAdd.Size = new System.Drawing.Size(206, 47);
            this.btnTransactionsAdd.TabIndex = 1;
            this.btnTransactionsAdd.Text = "Add";
            this.btnTransactionsAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransactionsAdd.UseVisualStyleBackColor = false;
            // 
            // panelItems
            // 
            this.panelItems.Controls.Add(this.btnItemsView);
            this.panelItems.Controls.Add(this.btnItemsUpdate);
            this.panelItems.Controls.Add(this.btnItemsDelete);
            this.panelItems.Controls.Add(this.btnItemsAdd);
            this.panelItems.Location = new System.Drawing.Point(790, 75);
            this.panelItems.Margin = new System.Windows.Forms.Padding(0);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(201, 208);
            this.panelItems.TabIndex = 12;
            this.panelItems.Visible = false;
            // 
            // btnItemsView
            // 
            this.btnItemsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnItemsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemsView.FlatAppearance.BorderSize = 0;
            this.btnItemsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemsView.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsView.ForeColor = System.Drawing.Color.White;
            this.btnItemsView.Location = new System.Drawing.Point(0, 141);
            this.btnItemsView.Name = "btnItemsView";
            this.btnItemsView.Size = new System.Drawing.Size(201, 47);
            this.btnItemsView.TabIndex = 4;
            this.btnItemsView.Text = "View";
            this.btnItemsView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnItemsView.UseVisualStyleBackColor = false;
            // 
            // btnItemsUpdate
            // 
            this.btnItemsUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnItemsUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemsUpdate.FlatAppearance.BorderSize = 0;
            this.btnItemsUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemsUpdate.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsUpdate.ForeColor = System.Drawing.Color.White;
            this.btnItemsUpdate.Location = new System.Drawing.Point(0, 94);
            this.btnItemsUpdate.Name = "btnItemsUpdate";
            this.btnItemsUpdate.Size = new System.Drawing.Size(201, 47);
            this.btnItemsUpdate.TabIndex = 3;
            this.btnItemsUpdate.Text = "Update";
            this.btnItemsUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnItemsUpdate.UseVisualStyleBackColor = false;
            this.btnItemsUpdate.Click += new System.EventHandler(this.btnItemsUpdate_Click);
            // 
            // btnItemsDelete
            // 
            this.btnItemsDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnItemsDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemsDelete.FlatAppearance.BorderSize = 0;
            this.btnItemsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemsDelete.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsDelete.ForeColor = System.Drawing.Color.White;
            this.btnItemsDelete.Location = new System.Drawing.Point(0, 47);
            this.btnItemsDelete.Name = "btnItemsDelete";
            this.btnItemsDelete.Size = new System.Drawing.Size(201, 47);
            this.btnItemsDelete.TabIndex = 2;
            this.btnItemsDelete.Text = "Delete";
            this.btnItemsDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnItemsDelete.UseVisualStyleBackColor = false;
            this.btnItemsDelete.Click += new System.EventHandler(this.btnItemsDelete_Click);
            // 
            // btnItemsAdd
            // 
            this.btnItemsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnItemsAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemsAdd.FlatAppearance.BorderSize = 0;
            this.btnItemsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemsAdd.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsAdd.ForeColor = System.Drawing.Color.White;
            this.btnItemsAdd.Location = new System.Drawing.Point(0, 0);
            this.btnItemsAdd.Name = "btnItemsAdd";
            this.btnItemsAdd.Size = new System.Drawing.Size(201, 47);
            this.btnItemsAdd.TabIndex = 1;
            this.btnItemsAdd.Text = "Add";
            this.btnItemsAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnItemsAdd.UseVisualStyleBackColor = false;
            this.btnItemsAdd.Click += new System.EventHandler(this.btnItemsAdd_Click);
            // 
            // panelServices
            // 
            this.panelServices.Controls.Add(this.btnServicesView);
            this.panelServices.Controls.Add(this.btnServicesUpdate);
            this.panelServices.Controls.Add(this.btnServicesDelete);
            this.panelServices.Controls.Add(this.btnServicesAdd);
            this.panelServices.Location = new System.Drawing.Point(583, 76);
            this.panelServices.Margin = new System.Windows.Forms.Padding(0);
            this.panelServices.Name = "panelServices";
            this.panelServices.Size = new System.Drawing.Size(201, 208);
            this.panelServices.TabIndex = 11;
            this.panelServices.Visible = false;
            // 
            // btnServicesView
            // 
            this.btnServicesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnServicesView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicesView.FlatAppearance.BorderSize = 0;
            this.btnServicesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesView.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicesView.ForeColor = System.Drawing.Color.White;
            this.btnServicesView.Location = new System.Drawing.Point(0, 141);
            this.btnServicesView.Name = "btnServicesView";
            this.btnServicesView.Size = new System.Drawing.Size(201, 47);
            this.btnServicesView.TabIndex = 4;
            this.btnServicesView.Text = "View";
            this.btnServicesView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServicesView.UseVisualStyleBackColor = false;
            // 
            // btnServicesUpdate
            // 
            this.btnServicesUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnServicesUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicesUpdate.FlatAppearance.BorderSize = 0;
            this.btnServicesUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesUpdate.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicesUpdate.ForeColor = System.Drawing.Color.White;
            this.btnServicesUpdate.Location = new System.Drawing.Point(0, 94);
            this.btnServicesUpdate.Name = "btnServicesUpdate";
            this.btnServicesUpdate.Size = new System.Drawing.Size(201, 47);
            this.btnServicesUpdate.TabIndex = 3;
            this.btnServicesUpdate.Text = "Update";
            this.btnServicesUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServicesUpdate.UseVisualStyleBackColor = false;
            this.btnServicesUpdate.Click += new System.EventHandler(this.btnServicesUpdate_Click);
            // 
            // btnServicesDelete
            // 
            this.btnServicesDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnServicesDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicesDelete.FlatAppearance.BorderSize = 0;
            this.btnServicesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesDelete.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicesDelete.ForeColor = System.Drawing.Color.White;
            this.btnServicesDelete.Location = new System.Drawing.Point(0, 47);
            this.btnServicesDelete.Name = "btnServicesDelete";
            this.btnServicesDelete.Size = new System.Drawing.Size(201, 47);
            this.btnServicesDelete.TabIndex = 2;
            this.btnServicesDelete.Text = "Delete";
            this.btnServicesDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServicesDelete.UseVisualStyleBackColor = false;
            this.btnServicesDelete.Click += new System.EventHandler(this.btnServicesDelete_Click);
            // 
            // btnServicesAdd
            // 
            this.btnServicesAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnServicesAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicesAdd.FlatAppearance.BorderSize = 0;
            this.btnServicesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesAdd.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicesAdd.ForeColor = System.Drawing.Color.White;
            this.btnServicesAdd.Location = new System.Drawing.Point(0, 0);
            this.btnServicesAdd.Name = "btnServicesAdd";
            this.btnServicesAdd.Size = new System.Drawing.Size(201, 47);
            this.btnServicesAdd.TabIndex = 1;
            this.btnServicesAdd.Text = "Add";
            this.btnServicesAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServicesAdd.UseVisualStyleBackColor = false;
            this.btnServicesAdd.Click += new System.EventHandler(this.btnServicesAdd_Click);
            // 
            // panelVehicles
            // 
            this.panelVehicles.Controls.Add(this.btnVehiclesView);
            this.panelVehicles.Controls.Add(this.btnVehiclesUpdate);
            this.panelVehicles.Controls.Add(this.btnVehiclesDelete);
            this.panelVehicles.Controls.Add(this.btnVehiclesAdd);
            this.panelVehicles.Location = new System.Drawing.Point(376, 76);
            this.panelVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.panelVehicles.Name = "panelVehicles";
            this.panelVehicles.Size = new System.Drawing.Size(201, 208);
            this.panelVehicles.TabIndex = 10;
            this.panelVehicles.Visible = false;
            // 
            // btnVehiclesView
            // 
            this.btnVehiclesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnVehiclesView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiclesView.FlatAppearance.BorderSize = 0;
            this.btnVehiclesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiclesView.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiclesView.ForeColor = System.Drawing.Color.White;
            this.btnVehiclesView.Location = new System.Drawing.Point(0, 141);
            this.btnVehiclesView.Name = "btnVehiclesView";
            this.btnVehiclesView.Size = new System.Drawing.Size(201, 47);
            this.btnVehiclesView.TabIndex = 4;
            this.btnVehiclesView.Text = "View";
            this.btnVehiclesView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVehiclesView.UseVisualStyleBackColor = false;
            // 
            // btnVehiclesUpdate
            // 
            this.btnVehiclesUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnVehiclesUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiclesUpdate.FlatAppearance.BorderSize = 0;
            this.btnVehiclesUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiclesUpdate.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiclesUpdate.ForeColor = System.Drawing.Color.White;
            this.btnVehiclesUpdate.Location = new System.Drawing.Point(0, 94);
            this.btnVehiclesUpdate.Name = "btnVehiclesUpdate";
            this.btnVehiclesUpdate.Size = new System.Drawing.Size(201, 47);
            this.btnVehiclesUpdate.TabIndex = 3;
            this.btnVehiclesUpdate.Text = "Update";
            this.btnVehiclesUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVehiclesUpdate.UseVisualStyleBackColor = false;
            // 
            // btnVehiclesDelete
            // 
            this.btnVehiclesDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnVehiclesDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiclesDelete.FlatAppearance.BorderSize = 0;
            this.btnVehiclesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiclesDelete.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiclesDelete.ForeColor = System.Drawing.Color.White;
            this.btnVehiclesDelete.Location = new System.Drawing.Point(0, 47);
            this.btnVehiclesDelete.Name = "btnVehiclesDelete";
            this.btnVehiclesDelete.Size = new System.Drawing.Size(201, 47);
            this.btnVehiclesDelete.TabIndex = 2;
            this.btnVehiclesDelete.Text = "Delete";
            this.btnVehiclesDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVehiclesDelete.UseVisualStyleBackColor = false;
            // 
            // btnVehiclesAdd
            // 
            this.btnVehiclesAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnVehiclesAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiclesAdd.FlatAppearance.BorderSize = 0;
            this.btnVehiclesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiclesAdd.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiclesAdd.ForeColor = System.Drawing.Color.White;
            this.btnVehiclesAdd.Location = new System.Drawing.Point(0, 0);
            this.btnVehiclesAdd.Name = "btnVehiclesAdd";
            this.btnVehiclesAdd.Size = new System.Drawing.Size(201, 47);
            this.btnVehiclesAdd.TabIndex = 1;
            this.btnVehiclesAdd.Text = "Add";
            this.btnVehiclesAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVehiclesAdd.UseVisualStyleBackColor = false;
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Location = new System.Drawing.Point(790, 29);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(201, 47);
            this.btnItems.TabIndex = 8;
            this.btnItems.Text = "Items";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnVehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVehicles.FlatAppearance.BorderSize = 0;
            this.btnVehicles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicles.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicles.ForeColor = System.Drawing.Color.White;
            this.btnVehicles.Location = new System.Drawing.Point(376, 29);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(201, 47);
            this.btnVehicles.TabIndex = 7;
            this.btnVehicles.Text = "Vehicles";
            this.btnVehicles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVehicles.UseVisualStyleBackColor = false;
            this.btnVehicles.Click += new System.EventHandler(this.btnVehicles_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServices.ForeColor = System.Drawing.Color.White;
            this.btnServices.Location = new System.Drawing.Point(583, 29);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(201, 47);
            this.btnServices.TabIndex = 6;
            this.btnServices.Text = "Services";
            this.btnServices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Location = new System.Drawing.Point(164, 29);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(206, 47);
            this.btnTransactions.TabIndex = 5;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.BackColor = System.Drawing.Color.White;
            this.tabPageInventory.Location = new System.Drawing.Point(4, 23);
            this.tabPageInventory.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(1104, 685);
            this.tabPageInventory.TabIndex = 1;
            // 
            // tabPageReports
            // 
            this.tabPageReports.BackColor = System.Drawing.Color.White;
            this.tabPageReports.Location = new System.Drawing.Point(4, 23);
            this.tabPageReports.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Size = new System.Drawing.Size(1104, 685);
            this.tabPageReports.TabIndex = 2;
            // 
            // tabPageAnalytics
            // 
            this.tabPageAnalytics.BackColor = System.Drawing.Color.White;
            this.tabPageAnalytics.Location = new System.Drawing.Point(4, 23);
            this.tabPageAnalytics.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageAnalytics.Name = "tabPageAnalytics";
            this.tabPageAnalytics.Size = new System.Drawing.Size(1104, 685);
            this.tabPageAnalytics.TabIndex = 3;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.Location = new System.Drawing.Point(4, 23);
            this.tabPageSettings.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageSettings.Size = new System.Drawing.Size(1104, 685);
            this.tabPageSettings.TabIndex = 4;
            // 
            // deleteItemUserControl1
            // 
            this.deleteItemUserControl1.Location = new System.Drawing.Point(8, 82);
            this.deleteItemUserControl1.Name = "deleteItemUserControl1";
            this.deleteItemUserControl1.Size = new System.Drawing.Size(983, 580);
            this.deleteItemUserControl1.TabIndex = 14;
            this.deleteItemUserControl1.Visible = false;
            // 
            // addItemUserControl1
            // 
            this.addItemUserControl1.Location = new System.Drawing.Point(8, 82);
            this.addItemUserControl1.mainForm = null;
            this.addItemUserControl1.Name = "addItemUserControl1";
            this.addItemUserControl1.Size = new System.Drawing.Size(983, 580);
            this.addItemUserControl1.TabIndex = 13;
            this.addItemUserControl1.Visible = false;
            // 
            // updateItemUserControl1
            // 
            this.updateItemUserControl1.Location = new System.Drawing.Point(8, 82);
            this.updateItemUserControl1.Name = "updateItemUserControl1";
            this.updateItemUserControl1.Size = new System.Drawing.Size(983, 580);
            this.updateItemUserControl1.TabIndex = 15;
            this.updateItemUserControl1.Visible = false;
            // 
            // addServiceUserControl1
            // 
            this.addServiceUserControl1.Location = new System.Drawing.Point(8, 82);
            this.addServiceUserControl1.Name = "addServiceUserControl1";
            this.addServiceUserControl1.Size = new System.Drawing.Size(983, 625);
            this.addServiceUserControl1.TabIndex = 16;
            this.addServiceUserControl1.Visible = false;
            // 
            // updateServiceUserControl1
            // 
            this.updateServiceUserControl1.Location = new System.Drawing.Point(8, 82);
            this.updateServiceUserControl1.Name = "updateServiceUserControl1";
            this.updateServiceUserControl1.Size = new System.Drawing.Size(983, 580);
            this.updateServiceUserControl1.TabIndex = 17;
            this.updateServiceUserControl1.Visible = false;
            // 
            // deleteServiceUserControl1
            // 
            this.deleteServiceUserControl1.Location = new System.Drawing.Point(8, 82);
            this.deleteServiceUserControl1.Name = "deleteServiceUserControl1";
            this.deleteServiceUserControl1.Size = new System.Drawing.Size(983, 580);
            this.deleteServiceUserControl1.TabIndex = 18;
            this.deleteServiceUserControl1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1112, 712);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picboxBooze);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBooze)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSales.ResumeLayout(false);
            this.panelTransactions.ResumeLayout(false);
            this.panelItems.ResumeLayout(false);
            this.panelServices.ResumeLayout(false);
            this.panelVehicles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.PictureBox picboxBooze;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.TabPage tabPageAnalytics;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.Button btnTransactionsView;
        private System.Windows.Forms.Button btnTransactionsUpdate;
        private System.Windows.Forms.Button btnTransactionsDelete;
        private System.Windows.Forms.Button btnTransactionsAdd;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnVehicles;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.Button btnItemsView;
        private System.Windows.Forms.Button btnItemsUpdate;
        private System.Windows.Forms.Button btnItemsDelete;
        private System.Windows.Forms.Button btnItemsAdd;
        private System.Windows.Forms.Panel panelServices;
        private System.Windows.Forms.Button btnServicesView;
        private System.Windows.Forms.Button btnServicesUpdate;
        private System.Windows.Forms.Button btnServicesDelete;
        private System.Windows.Forms.Button btnServicesAdd;
        private System.Windows.Forms.Panel panelVehicles;
        private System.Windows.Forms.Button btnVehiclesView;
        private System.Windows.Forms.Button btnVehiclesUpdate;
        private System.Windows.Forms.Button btnVehiclesDelete;
        private System.Windows.Forms.Button btnVehiclesAdd;
        private ItemForms.DeleteItemUserControl deleteItemUserControl1;
        private ItemForms.AddItemUserControl addItemUserControl1;
        private ItemForms.UpdateItemUserControl updateItemUserControl1;
        private ServiceForms.AddServiceUserControl addServiceUserControl1;
        private ServiceForms.UpdateServiceUserControl updateServiceUserControl1;
        private ServiceForms.DeleteServiceUserControl deleteServiceUserControl1;
    }
}