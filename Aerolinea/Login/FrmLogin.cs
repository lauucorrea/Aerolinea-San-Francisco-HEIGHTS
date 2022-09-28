using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace Login
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          LogCredenciales(txtUsuario.Text,txtPasswd.Text);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "lau123";
            txtPasswd.Text = "asd123";
        }
        private void LogCredenciales(string usuario,string passwd)
        {
            if (Administracion.AdministrarLogIn(usuario, passwd))
            {
                FrmMenuPrincipal menu = new FrmMenuPrincipal(Administracion.ObtenerVendedor(usuario, passwd));

                menu.Show();
                Hide();
            }
            else
            {
                txtUsuario.Text = String.Empty;
                txtPasswd.Text = String.Empty;

            }
        }
    }
}
