using Entidades;
using System;
using System.Windows.Forms;
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
            try
            {
                LogCredenciales(txtUsuario.Text, txtPasswd.Text);
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "lau123";
            txtPasswd.Text = "asd123";
        }
        private bool LogCredenciales(string usuario, string passwd)
        {
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(passwd))
            {

                if (Administracion.AdministrarLogIn(usuario, passwd))
                {
                    FrmMenuPrincipal menu = new FrmMenuPrincipal(Administracion.ObtenerVendedor(usuario, passwd));

                    menu.Show();
                    Hide();
                    return true;
                }
                else
                {
                    txtUsuario.Text = string.Empty;
                    txtPasswd.Text = string.Empty;
                }
            }
            throw new Exception("Los campos deben completarse para loguear");
            

        }
    }
}
