
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
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.lblTitleAdmin = new System.Windows.Forms.Label();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaUsuario
            // 
<<<<<<< HEAD
            this.btnAltaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAltaUsuario.Location = new System.Drawing.Point(127, 175);
            this.btnAltaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(133, 43);
            this.btnAltaUsuario.TabIndex = 0;
            this.btnAltaUsuario.Text = "Alta de Usuario";
            this.btnAltaUsuario.UseVisualStyleBackColor = true;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAddUser_Click);
=======
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUser.Location = new System.Drawing.Point(127, 175);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(133, 43);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Alta de Usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
>>>>>>> fff9d15e0e03e44deb0ffe191ab5be69a1de5560
            // 
            // btnEditarUsuario
            // 
<<<<<<< HEAD
            this.btnEditarUsuario.Location = new System.Drawing.Point(319, 175);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(133, 43);
            this.btnEditarUsuario.TabIndex = 1;
            this.btnEditarUsuario.Text = "Editar Usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditUser_Click);
=======
            this.btnEditUser.Location = new System.Drawing.Point(319, 175);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(133, 43);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Modificar Usuario";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
>>>>>>> fff9d15e0e03e44deb0ffe191ab5be69a1de5560
            // 
            // lblTitleAdmin
            // 
            this.lblTitleAdmin.AutoSize = true;
            this.lblTitleAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblTitleAdmin.Location = new System.Drawing.Point(149, 98);
            this.lblTitleAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleAdmin.Name = "lblTitleAdmin";
            this.lblTitleAdmin.Size = new System.Drawing.Size(283, 36);
=======
            this.lblTitleAdmin.Location = new System.Drawing.Point(144, 105);
            this.lblTitleAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleAdmin.Name = "lblTitleAdmin";
            this.lblTitleAdmin.Size = new System.Drawing.Size(274, 36);
>>>>>>> fff9d15e0e03e44deb0ffe191ab5be69a1de5560
            this.lblTitleAdmin.TabIndex = 2;
            this.lblTitleAdmin.Text = "Menú Administrador";
            // 
            // btnBajaUsuario
            // 
<<<<<<< HEAD
            this.btnBajaUsuario.Location = new System.Drawing.Point(227, 231);
            this.btnBajaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(133, 43);
            this.btnBajaUsuario.TabIndex = 3;
            this.btnBajaUsuario.Text = "Baja de Usuario";
            this.btnBajaUsuario.UseVisualStyleBackColor = true;
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnDeleteUser_Click);
=======
            this.btnDeleteUser.Location = new System.Drawing.Point(227, 231);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(133, 43);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Baja de Usuario";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
>>>>>>> fff9d15e0e03e44deb0ffe191ab5be69a1de5560
            // 
            // FormSysAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 395);
<<<<<<< HEAD
            this.Controls.Add(this.btnBajaUsuario);
            this.Controls.Add(this.lblTitleAdmin);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnAltaUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
=======
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.lblTitleAdmin);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> fff9d15e0e03e44deb0ffe191ab5be69a1de5560
            this.Name = "FormSysAdmin";
            this.Text = "System Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Label lblTitleAdmin;
        private System.Windows.Forms.Button btnBajaUsuario;
    }
}