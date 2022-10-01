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
                if (Administracion.AgregarClienteALista(txtNombrePasajero.Text, txtApellido.Text, (int)numDni.Value, (int)numEdad.Value))
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

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
    }
}
