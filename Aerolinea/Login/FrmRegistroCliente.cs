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
            MessageBoxButtons botonesOpciones = MessageBoxButtons.OK;
            DialogResult result;
            try
            {
                if (!Administracion.CheckearSiPersonaExiste((int)numDni.Value))
                {
                    if (Administracion.AgregarClienteALista(txtNombrePasajero.Text, txtApellido.Text, (int)numDni.Value, (int)numEdad.Value))
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
