
namespace BoozewasherApp.Forms.EmployeeForms
{
    partial class EmployeeHomeUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.btnTimeInOut = new System.Windows.Forms.Button();
            this.presentEmployeesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Employees";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 112);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(255, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 112);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 47);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employees Present";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(728, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 112);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 47);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employees Absent";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(494, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 112);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 47);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employees Late";
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAttendance.Location = new System.Drawing.Point(744, 327);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(212, 93);
            this.btnViewAttendance.TabIndex = 7;
            this.btnViewAttendance.Text = "View Attendance";
            this.btnViewAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewAttendance.UseVisualStyleBackColor = true;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // btnTimeInOut
            // 
            this.btnTimeInOut.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeInOut.Location = new System.Drawing.Point(744, 426);
            this.btnTimeInOut.Name = "btnTimeInOut";
            this.btnTimeInOut.Size = new System.Drawing.Size(212, 93);
            this.btnTimeInOut.TabIndex = 8;
            this.btnTimeInOut.Text = "Time In / Time Out";
            this.btnTimeInOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimeInOut.UseVisualStyleBackColor = true;
            this.btnTimeInOut.Click += new System.EventHandler(this.btnTimeInOut_Click);
            // 
            // presentEmployeesFlowLayoutPanel
            // 
            this.presentEmployeesFlowLayoutPanel.AutoScroll = true;
            this.presentEmployeesFlowLayoutPanel.BackColor = System.Drawing.Color.Gray;
            this.presentEmployeesFlowLayoutPanel.Location = new System.Drawing.Point(16, 239);
            this.presentEmployeesFlowLayoutPanel.Name = "presentEmployeesFlowLayoutPanel";
            this.presentEmployeesFlowLayoutPanel.Size = new System.Drawing.Size(722, 280);
            this.presentEmployeesFlowLayoutPanel.TabIndex = 9;
            this.presentEmployeesFlowLayoutPanel.WrapContents = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(744, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 185);
            this.panel5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 47);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employees Absent";
            // 
            // EmployeeHomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.presentEmployeesFlowLayoutPanel);
            this.Controls.Add(this.btnTimeInOut);
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeHomeUserControl";
            this.Size = new System.Drawing.Size(983, 542);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewAttendance;
        private System.Windows.Forms.Button btnTimeInOut;
        private System.Windows.Forms.FlowLayoutPanel presentEmployeesFlowLayoutPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
    }
}
