using Entidades;
using System;
using System.Windows.Forms;
namespace Vista
{
    public partial class FrmRegistroVuelo : Form
    {
        Avion avionSeleccionado;
        public FrmRegistroVuelo()
        {
            InitializeComponent();
        }

        private void FrmRegistroVuelo_Load(object sender, EventArgs e)
        {
            cmbDestinos.DataSource = Enum.GetValues(typeof(Destinos));
            MostrarAviones();
        }
        private void MostrarAviones()
        {
            if (lstAviones.Items.Count > 0)
            {
                lstAviones.Items.Clear();
            }

            lstAviones.DataSource = Registro.Aviones;

        }

        private void lstAviones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAviones.SelectedItem is not null)
            {
                txtOrigen.Text = "BuenosAires";
                txtMatricula.Clear();
                avionSeleccionado = (Avion)lstAviones.SelectedItem;
                txtMatricula.Text = avionSeleccionado.MatriculaAvion;

            }
        }

        private void btnCargarVuelo_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botonesOpciones = MessageBoxButtons.OK;
            DialogResult result;
            float costoVuelo;
            bool esInternacional;
            int horasDeVuelo;
            try
            {
                if (Administracion.CheckearSiAvionExiste(txtMatricula.Text))
                {
                    if (numHora.Value != 0 && numMinutos.Value != 0)
                    {

                        esInternacional = EsInternacional(cmbDestinos.SelectedIndex);
                        horasDeVuelo = Administracion.CalcularCantidadDeHorasDeVuelo(esInternacional);
                        costoVuelo = Administracion.CalcularCostoDelVuelo(esInternacional, (int)numHora.Value);

                        if (Administracion.AgregarVueloALista(txtOrigen.Text, cmbDestinos.SelectedIndex, esInternacional, (int)numHora.Value, (int)numMinutos.Value, horasDeVuelo, costoVuelo, txtMatricula.Text))
                        {
                            result = MessageBox.Show("Vuelo agregado con exito!", "", botonesOpciones);
                            if (result == DialogResult.OK)
                            {
                                Close();
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Los campos numericos deben ser completados");
                    }
                }
                else
                {
                    throw new Exception("El cliente no existe en nuestros registros");
                }

            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }
        private bool EsInternacional(int indice)
        {
            bool ret = false;
            if (indice >= 0 && indice <= 14)
            {
                ret = false;
            }
            else if (indice > 14)
            {
                ret = true;
            }
            return ret;
        }


    }
}
