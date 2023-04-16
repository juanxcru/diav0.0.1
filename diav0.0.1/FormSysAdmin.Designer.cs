
namespace diav0._0._1
{
    partial class FormSysAdmin
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
            this.AddUser = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.Button();
            this.lblTitleAdmin = new System.Windows.Forms.Label();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(109, 162);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(100, 35);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Add user";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditUser
            // 
            this.EditUser.Location = new System.Drawing.Point(253, 162);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(100, 35);
            this.EditUser.TabIndex = 1;
            this.EditUser.Text = "Edit user";
            this.EditUser.UseVisualStyleBackColor = true;
            // 
            // lblTitleAdmin
            // 
            this.lblTitleAdmin.AutoSize = true;
            this.lblTitleAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAdmin.Location = new System.Drawing.Point(108, 85);
            this.lblTitleAdmin.Name = "lblTitleAdmin";
            this.lblTitleAdmin.Size = new System.Drawing.Size(220, 29);
            this.lblTitleAdmin.TabIndex = 2;
            this.lblTitleAdmin.Text = "Administrator Menu";
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(184, 208);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(100, 35);
            this.DeleteUser.TabIndex = 3;
            this.DeleteUser.Text = "Delete user";
            this.DeleteUser.UseVisualStyleBackColor = true;
            // 
            // FormSysAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 321);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.lblTitleAdmin);
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.AddUser);
            this.Name = "FormSysAdmin";
            this.Text = "System Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Label lblTitleAdmin;
        private System.Windows.Forms.Button DeleteUser;
    }
}