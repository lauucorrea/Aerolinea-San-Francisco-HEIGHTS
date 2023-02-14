using Entidades;
using Serializacion;
using Sql_Aerolinea;
using System;
using System.IO;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmLogin : Form
    {
        Cliente clienteLogin;
        Vendedor vendedorLogin;
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
            try
            {

                if (ObtenerPersonas() && ObtenerAviones())
                {
                    txtUsuario.Text = "lau123";
                    txtPasswd.Text = "asd123";
                }
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
            
        }
        private bool ObtenerPersonas()
        {
            bool ret = false;
            if (Registro.Personas is not null)
            {

                Tabla_Personas consultaPersonas = new();
                Clase_serializadora serializadora = new();

                if (File.Exists(serializadora.RutaPersonas))
                {
                    serializadora.LevantarPersonasXML();
                    if (Registro.Personas.Count > 0)
                    {
                        foreach (Persona persona in Registro.Personas)
                        {
                            consultaPersonas.SubirPersonaBD(persona);
                        }
                        ret = true;
                    }
                }
                else
                {
                    Registro.Personas = consultaPersonas.ObtenerPersonasBD();
                    if (Registro.Personas is not null)
                    {
                        ret = true;
                    }
                }
            }
            return ret;
        }
        private bool ObtenerAviones()
        {
            bool ret = false;
            if (Registro.Personas is not null)
            {

                Tabla_Aviones consultaAviones = new();
                Clase_serializadora serializadora = new();

                if (File.Exists(serializadora.RutaAviones))
                {
                    serializadora.LevantarAvionesXML();
                    if (Registro.Aviones.Count > 0)
                    {
                        foreach (Avion avion in Registro.Aviones)
                        {
                            consultaAviones.SubirAvionBD(avion);
                        }
                        ret = true;
                    }
                }
                else
                {
                    Registro.Aviones = consultaAviones.ObtenerAvionesBD();
                    if (Registro.Aviones is not null)
                    {
                        ret = true;
                    }
                }
            }
            return ret;
        }

        private bool LogCredenciales(string usuario, string passwd)
        {
            string excepcion = "";
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(passwd))
            {
                foreach (Persona persona in Registro.Personas)
                {
                    if (persona.GetType() == typeof(Cliente))
                    {
                        clienteLogin = (Cliente)persona;
                        if (clienteLogin.AdministrarLogIn(usuario, passwd))
                        {
                            FrmMenuPrincipal menu = new(clienteLogin);
                            menu.Show();
                            Hide();
                            return true;

                        }
                        else
                        {
                            txtUsuario.Text = string.Empty;
                            txtPasswd.Text = string.Empty;
                            excepcion = "Los registros del cliente no coinciden";
                        }
                    }
                    else if (persona.GetType() == typeof(Vendedor))
                    {

                        vendedorLogin = (Vendedor)persona;
                        if (vendedorLogin.AdministrarLogIn(usuario, passwd))
                        {
                            FrmMenuPrincipal menu = new(vendedorLogin);
                            menu.Show();
                            Hide();
                            return true;
                        }
                        else
                        {
                            txtUsuario.Text = string.Empty;
                            txtPasswd.Text = string.Empty;
                            excepcion = "Los registros del vendedor no coinciden";
                        }
                    }
                }
                if (!string.IsNullOrEmpty(excepcion))
                {
                    throw new Exception(excepcion);
                }
                return false;
            }
            throw new Exception("Los campos deben completarse para loguear");


        }
    }
}
