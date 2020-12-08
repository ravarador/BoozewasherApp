﻿namespace BoozewasherApp.Forms.SummaryForms
{
    partial class SummaryReportSelector
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
            this.grpboxDateRange = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerDateToRange = new System.Windows.Forms.DateTimePicker();
            this.datePickerDateFromRange = new System.Windows.Forms.DateTimePicker();
            this.radSelectDate = new System.Windows.Forms.RadioButton();
            this.radSelectDateRange = new System.Windows.Forms.RadioButton();
            this.grpboxDate = new System.Windows.Forms.GroupBox();
            this.datePickerSelectDate = new System.Windows.Forms.DateTimePicker();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpboxDateRange.SuspendLayout();
            this.grpboxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxDateRange
            // 
            this.grpboxDateRange.Controls.Add(this.label2);
            this.grpboxDateRange.Controls.Add(this.label1);
            this.grpboxDateRange.Controls.Add(this.datePickerDateToRange);
            this.grpboxDateRange.Controls.Add(this.datePickerDateFromRange);
            this.grpboxDateRange.Enabled = false;
            this.grpboxDateRange.Location = new System.Drawing.Point(30, 110);
            this.grpboxDateRange.Name = "grpboxDateRange";
            this.grpboxDateRange.Size = new System.Drawing.Size(223, 153);
            this.grpboxDateRange.TabIndex = 0;
            this.grpboxDateRange.TabStop = false;
            this.grpboxDateRange.Text = "Date Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date From:";
            // 
            // datePickerDateToRange
            // 
            this.datePickerDateToRange.Location = new System.Drawing.Point(9, 109);
            this.datePickerDateToRange.Name = "datePickerDateToRange";
            this.datePickerDateToRange.Size = new System.Drawing.Size(200, 20);
            this.datePickerDateToRange.TabIndex = 1;
            // 
            // datePickerDateFromRange
            // 
            this.datePickerDateFromRange.Location = new System.Drawing.Point(9, 41);
            this.datePickerDateFromRange.Name = "datePickerDateFromRange";
            this.datePickerDateFromRange.Size = new System.Drawing.Size(200, 20);
            this.datePickerDateFromRange.TabIndex = 0;
            // 
            // radSelectDate
            // 
            this.radSelectDate.AutoSize = true;
            this.radSelectDate.Checked = true;
            this.radSelectDate.Location = new System.Drawing.Point(30, 12);
            this.radSelectDate.Name = "radSelectDate";
            this.radSelectDate.Size = new System.Drawing.Size(81, 17);
            this.radSelectDate.TabIndex = 1;
            this.radSelectDate.TabStop = true;
            this.radSelectDate.Text = "Select Date";
            this.radSelectDate.UseVisualStyleBackColor = true;
            this.radSelectDate.Click += new System.EventHandler(this.radSelectDateRange_Click);
            // 
            // radSelectDateRange
            // 
            this.radSelectDateRange.AutoSize = true;
            this.radSelectDateRange.Location = new System.Drawing.Point(137, 12);
            this.radSelectDateRange.Name = "radSelectDateRange";
            this.radSelectDateRange.Size = new System.Drawing.Size(116, 17);
            this.radSelectDateRange.TabIndex = 2;
            this.radSelectDateRange.Text = "Select Date Range";
            this.radSelectDateRange.UseVisualStyleBackColor = true;
            this.radSelectDateRange.Click += new System.EventHandler(this.radSelectDateRange_Click);
            // 
            // grpboxDate
            // 
            this.grpboxDate.Controls.Add(this.datePickerSelectDate);
            this.grpboxDate.Location = new System.Drawing.Point(30, 41);
            this.grpboxDate.Name = "grpboxDate";
            this.grpboxDate.Size = new System.Drawing.Size(223, 54);
            this.grpboxDate.TabIndex = 3;
            this.grpboxDate.TabStop = false;
            this.grpboxDate.Text = "Select Date";
            // 
            // datePickerSelectDate
            // 
            this.datePickerSelectDate.Location = new System.Drawing.Point(9, 19);
            this.datePickerSelectDate.Name = "datePickerSelectDate";
            this.datePickerSelectDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerSelectDate.TabIndex = 4;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(281, 12);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(107, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(281, 41);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // SummaryReportSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 312);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.grpboxDate);
            this.Controls.Add(this.radSelectDateRange);
            this.Controls.Add(this.radSelectDate);
            this.Controls.Add(this.grpboxDateRange);
            this.Name = "SummaryReportSelector";
            this.Text = "Summary Report Selector";
            this.grpboxDateRange.ResumeLayout(false);
            this.grpboxDateRange.PerformLayout();
            this.grpboxDate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxDateRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerDateToRange;
        private System.Windows.Forms.DateTimePicker datePickerDateFromRange;
        private System.Windows.Forms.RadioButton radSelectDate;
        private System.Windows.Forms.RadioButton radSelectDateRange;
        private System.Windows.Forms.GroupBox grpboxDate;
        private System.Windows.Forms.DateTimePicker datePickerSelectDate;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrint;
    }
}