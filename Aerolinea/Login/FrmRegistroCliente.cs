using Entidades;
using System;
using System.Windows.Forms;
namespace Login
{
    public partial class FrmRegistroPasajero : Form
    {
        private Vendedor vendedorDePasajero;
        public FrmRegistroPasajero()
        {
            InitializeComponent();
        }

        public FrmRegistroPasajero(Vendedor vendedorDeTurno) : this()
        {
            vendedorDePasajero = vendedorDeTurno;
        }

        private void RegistroPasajero_Load(object sender, EventArgs e)
        {

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int dni;
            MessageBoxButtons botonesOpciones = MessageBoxButtons.OK;
            DialogResult result;
            try
            {
                if (int.TryParse(txtDni.Text, out dni))
                {
                    if (!Administracion.CheckearSiPersonaExiste(dni))
                    {
                        if (Administracion.AgregarClienteALista(txtNombrePasajero.Text, txtApellido.Text, txtDni.Text, txtEdad.Text))
                        {
                            result = MessageBox.Show("Persona agregada con exito!", "", botonesOpciones);
                            if (result == DialogResult.OK)
                            {
                                Close();
                            }
                        }
                    }
                    else
                    {
                      throw new Exception("El cliente no existe en nuestros registros");
                    }
                }
                else
                {
                    throw new Exception("El tipo de dato del dni es incorrecto");
                }
            }
            catch (Exception ex)
            {
                txtErrores.Text = ex.Message;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
