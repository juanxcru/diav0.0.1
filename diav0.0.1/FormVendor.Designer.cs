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
            this.btnComenzarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultarVenta = new System.Windows.Forms.Button();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComenzarVenta
            // 
            this.btnComenzarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComenzarVenta.Location = new System.Drawing.Point(119, 156);
            this.btnComenzarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnComenzarVenta.Name = "btnComenzarVenta";
            this.btnComenzarVenta.Size = new System.Drawing.Size(130, 44);
            this.btnComenzarVenta.TabIndex = 0;
            this.btnComenzarVenta.Text = "Comenzar Venta";
            this.btnComenzarVenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConsultarVenta
            // 
            this.btnConsultarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarVenta.Location = new System.Drawing.Point(119, 224);
            this.btnConsultarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarVenta.Name = "btnConsultarVenta";
            this.btnConsultarVenta.Size = new System.Drawing.Size(130, 44);
            this.btnConsultarVenta.TabIndex = 2;
            this.btnConsultarVenta.Text = "Consultar Venta";
            this.btnConsultarVenta.UseVisualStyleBackColor = true;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearCliente.Location = new System.Drawing.Point(322, 156);
            this.btnCrearCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(130, 44);
            this.btnCrearCliente.TabIndex = 3;
            this.btnCrearCliente.Text = "Crear Cliente";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarCliente.Location = new System.Drawing.Point(322, 224);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(130, 44);
            this.btnModificarCliente.TabIndex = 4;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // FormVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 318);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.btnConsultarVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComenzarVenta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVendor";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComenzarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarVenta;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Button btnModificarCliente;
    }
}