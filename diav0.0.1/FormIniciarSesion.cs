using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace diav0._0._1
{
    public partial class FormIniciarSesion : Form
    {
        public FormIniciarSesion()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BUE.Usuario objUsuario = new BUE.Usuario();
            BLL.Usuario gestorUsuario = new BLL.Usuario();

            objUsuario = gestorUsuario.ValidarUsuario(txtbxUser.Text, txtbxPassword.Text);


            if (objUsuario == null)
            {
                MessageBox.Show("Usuario o clave invalido");
            }
            else
            {
                switch (objUsuario.Perfil.ID)
                {

                    case 1:
                        {
                            FormSysAdmin frmSysAdm = new FormSysAdmin();
                            frmSysAdm.ShowDialog();
                            break;
                        }
                    case 2:
                        {
                            FormManager frmManager = new FormManager();
                            frmManager.ShowDialog();
                            
                            break;
                        }
                    case 3:
                        {
                            FormVendor frmVendor = new FormVendor();
                            frmVendor.ShowDialog();
                            break;
                        }
                    case 4:
                        {
                            
                            break;
                        }
                }


            }

            


        }

        private void txtbxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
