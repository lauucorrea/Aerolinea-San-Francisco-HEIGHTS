using Entidades;
using System;
using System.Windows.Forms;
using Validaciones;
namespace Vista
{
    public partial class FrmAltaAviones : Form
    {
        public FrmAltaAviones()
        {
            InitializeComponent();
        }

        private void FrmAltaAviones_Load(object sender, EventArgs e)
        {
            MostrarAviones();
        }

        private void MostrarAviones()
        {
            rchListaAviones.Clear();

            foreach (Avion avion in Registro.Aviones)
            {
                if (avion is not null)
                {
                    rchListaAviones.AppendText(avion.ToString());
                }
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargarAvion_Click(object sender, EventArgs e)
        {
            try
            {
                CargarAvion();
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }

        }

        private void CargarAvion()
        {
            MessageBoxButtons botonesOpciones = MessageBoxButtons.OK;
            DialogResult result;
            if (numAsientos.Value != 0 && numBodega.Value != 0 && numToilets.Value != 0)
            {
                if (txtMatricula.Text != "")
                {
                    if (rbtNo.Checked || rbtSi.Checked)
                    {
                        if (ValidadoraDeDatos.ValidarAlfanumerico(txtMatricula.Text))
                        {
                            if (Administracion.AgregarAvionALista(rbtSi.Checked, (int)numAsientos.Value, numBodega.Value, (int)numToilets.Value, txtMatricula.Text.ToUpper()))
                            {

                                result = MessageBox.Show("Avion agregado con exito!", "", botonesOpciones);
                                if (result == DialogResult.OK)
                                {
                                    MostrarAviones();
                                }
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Debe elegir si ofrece comida o no");
                    }

                }
                else
                {
                    throw new Exception("El campo de la matricula no debe estar vacio");
                }
            }
            else
            {
                throw new Exception("Los campos numericos deben ser completados");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            const string mensaje = "Estas seguro de que queres cerrar?";
            const string comentario = "Formulario cerrandose";
            var result = MessageBox.Show(mensaje, comentario, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
