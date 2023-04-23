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
            this.WeeklyReport.Location = new System.Drawing.Point(188, 217);
            this.WeeklyReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WeeklyReport.Name = "WeeklyReport";
            this.WeeklyReport.Size = new System.Drawing.Size(100, 28);
            this.WeeklyReport.TabIndex = 0;
            this.WeeklyReport.Text = "Semanal";
            this.WeeklyReport.UseVisualStyleBackColor = true;
            this.WeeklyReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // MonthlyReport
            // 
            this.MonthlyReport.Location = new System.Drawing.Point(355, 217);
            this.MonthlyReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonthlyReport.Name = "MonthlyReport";
            this.MonthlyReport.Size = new System.Drawing.Size(100, 28);
            this.MonthlyReport.TabIndex = 1;
            this.MonthlyReport.Text = "Mensual";
            this.MonthlyReport.UseVisualStyleBackColor = true;
            // 
            // VendorsReport
            // 
            this.VendorsReport.Location = new System.Drawing.Point(532, 217);
            this.VendorsReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VendorsReport.Name = "VendorsReport";
            this.VendorsReport.Size = new System.Drawing.Size(100, 28);
            this.VendorsReport.TabIndex = 2;
            this.VendorsReport.Text = "Vendedores";
            this.VendorsReport.UseVisualStyleBackColor = true;
            // 
            // reports
            // 
            this.reports.AutoSize = true;
            this.reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.Location = new System.Drawing.Point(325, 96);
            this.reports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(170, 42);
            this.reports.TabIndex = 3;
            this.reports.Text = "Reportes";
            this.reports.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 380);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.VendorsReport);
            this.Controls.Add(this.MonthlyReport);
            this.Controls.Add(this.WeeklyReport);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormManager";
            this.Text = "Gerente";
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