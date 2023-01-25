using Entidades;
using Serializacion;
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


        /// <summary>
        /// Intenta agregar un cliente a la Lista Clientes cuando se hace clic en aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botonesOpciones = MessageBoxButtons.OK;
            DialogResult result;
            try
            {
                if (Administracion.AgregarClienteALista(txtNombrePasajero.Text, txtApellido.Text, (int)numDni.Value, (int)numEdad.Value, txtUsuario.Text,txtPasswd.Text))
                {
                    result = MessageBox.Show("Persona agregada con exito!", "", botonesOpciones);
                    if (result == DialogResult.OK)
                    {
                        Close();
                    }
                }

            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }


        /// <summary>
        /// chequea que todos los campos esten completos cada vez que se cambia el estado de uno de ellos
        /// </summary>
        private void EvaluarCampos()
        {
            if (!string.IsNullOrEmpty(txtNombrePasajero.Text) && !string.IsNullOrEmpty(txtApellido.Text) && numEdad.Value != 0 && numDni.Value != 0)
            {
                btnAceptar.Enabled = true;
            }
        }

        private void txtNombrePasajero_TextChanged(object sender, EventArgs e)
        {
            EvaluarCampos();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            EvaluarCampos();
        }

        private void numEdad_ValueChanged(object sender, EventArgs e)
        {
            EvaluarCampos();
        }

        private void numDni_ValueChanged(object sender, EventArgs e)
        {
            EvaluarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            const string mensaje = "Estas seguro de que queres cerrar?";
            const string comentario = "Formulario cerrandose";
            var result = MessageBox.Show(mensaje, comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Clase_serializadora serializadora = new();
                serializadora.GuardarPersonasXML();
                Application.Exit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
