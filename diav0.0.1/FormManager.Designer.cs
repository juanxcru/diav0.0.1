namespace diav0._0._1
{
    partial class FormManager
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
            this.WeeklyReport = new System.Windows.Forms.Button();
            this.MonthlyReport = new System.Windows.Forms.Button();
            this.VendorsReport = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeeklyReport
            // 
            this.WeeklyReport.Location = new System.Drawing.Point(141, 176);
            this.WeeklyReport.Name = "WeeklyReport";
            this.WeeklyReport.Size = new System.Drawing.Size(75, 23);
            this.WeeklyReport.TabIndex = 0;
            this.WeeklyReport.Text = "Weekly";
            this.WeeklyReport.UseVisualStyleBackColor = true;
            this.WeeklyReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // MonthlyReport
            // 
            this.MonthlyReport.Location = new System.Drawing.Point(266, 176);
            this.MonthlyReport.Name = "MonthlyReport";
            this.MonthlyReport.Size = new System.Drawing.Size(75, 23);
            this.MonthlyReport.TabIndex = 1;
            this.MonthlyReport.Text = "Monthly";
            this.MonthlyReport.UseVisualStyleBackColor = true;
            // 
            // VendorsReport
            // 
            this.VendorsReport.Location = new System.Drawing.Point(399, 176);
            this.VendorsReport.Name = "VendorsReport";
            this.VendorsReport.Size = new System.Drawing.Size(75, 23);
            this.VendorsReport.TabIndex = 2;
            this.VendorsReport.Text = "Vendors";
            this.VendorsReport.UseVisualStyleBackColor = true;
            // 
            // reports
            // 
            this.reports.AutoSize = true;
            this.reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.Location = new System.Drawing.Point(244, 78);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(120, 36);
            this.reports.TabIndex = 3;
            this.reports.Text = "Reports";
            this.reports.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 309);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.VendorsReport);
            this.Controls.Add(this.MonthlyReport);
            this.Controls.Add(this.WeeklyReport);
            this.Name = "FormManager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WeeklyReport;
        private System.Windows.Forms.Button MonthlyReport;
        private System.Windows.Forms.Button VendorsReport;
        private System.Windows.Forms.Label reports;
    }
}