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
            
            if (Administracion.AdministrarLogIn(txtUsuario.Text, txtPasswd.Text))
            { 
                FrmMenu menu = new FrmMenu(Administracion.ObtenerVendedor(txtUsuario.Text, txtPasswd.Text));

                menu.Show();
                Hide();
            }
            else
            {
                txtUsuario.Text = String.Empty;
                txtPasswd.Text = String.Empty;
                
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
