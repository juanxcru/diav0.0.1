﻿namespace diav0._0._1
{
    partial class FormVendor
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
            this.SalesAdm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientsAdm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalesAdm
            // 
            this.SalesAdm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalesAdm.Location = new System.Drawing.Point(89, 127);
            this.SalesAdm.Name = "SalesAdm";
            this.SalesAdm.Size = new System.Drawing.Size(75, 23);
            this.SalesAdm.TabIndex = 0;
            this.SalesAdm.Text = "Sales";
            this.SalesAdm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClientsAdm
            // 
            this.ClientsAdm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClientsAdm.Location = new System.Drawing.Point(243, 127);
            this.ClientsAdm.Name = "ClientsAdm";
            this.ClientsAdm.Size = new System.Drawing.Size(75, 23);
            this.ClientsAdm.TabIndex = 2;
            this.ClientsAdm.Text = "Clients";
            this.ClientsAdm.UseVisualStyleBackColor = true;
            // 
            // FormVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 258);
            this.Controls.Add(this.ClientsAdm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesAdm);
            this.Name = "FormVendor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalesAdm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClientsAdm;
    }
}