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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //mandar info de los input a BBL

            User userbuff = new User();
            int nxtScn =  userbuff.Login(txtbxUser.Text, txtbxPassword.Text);



            switch (nxtScn) {

                case 1 : 
                    { 
                        FormSysAdmin frmSysAdm = new FormSysAdmin();
                        frmSysAdm.ShowDialog();
                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case -1: 
                    {
                        MessageBox.Show("Datos de Login incorrectos");
                        txtbxUser.Text = "";
                        txtbxPassword.Text = "";
                        break;
                    }

            }

            


        }
    }
}
