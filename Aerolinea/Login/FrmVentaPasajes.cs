using Entidades;
using System;
using System.Windows.Forms;
namespace Vista
{
    public partial class FrmVentaPasajes : Form
    {
        Cliente clienteAtendido;
        Vuelo vueloSeleccionado;
        int indiceDestinos;
        private FrmVentaPasajes()
        {
            InitializeComponent();
        }

        public FrmVentaPasajes(Cliente clienteElegido) : this()
        {
            clienteAtendido = clienteElegido;
        }

        private void FrmVentaPasajes_Load(object sender, EventArgs e)
        {
            cmbDestinos.DataSource = Enum.GetValues(typeof(Destinos));
            txtNombre.Text = clienteAtendido.Nombre;
            txtDni.Text = clienteAtendido.Dni.ToString();
            txtDni.ReadOnly = true;
            MostrarVuelos();
        }
        private void MostrarVuelos()
        {
            if (lstVuelos.Items.Count > 0)
            {
                lstVuelos.Items.Clear();
            }

            lstVuelos.DataSource = Registro.Vuelos;
        }

        private void lstVuelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarRbt();
            if (lstVuelos.SelectedItem is not null)
            {
                vueloSeleccionado = (Vuelo)lstVuelos.SelectedItem;
                CargarDatosVueloElegido();

            }

        }

        private void rbtCategoriaTurista_Click(object sender, EventArgs e)
        {
            rbtCategoriaTurista.Checked = true;
            if (rbtCategoriaPremium.Checked)
            {
                rbtCategoriaPremium.Checked = false;
            }
        }

        private void rbtCategoriaPremium_Click(object sender, EventArgs e)
        {
            rbtCategoriaPremium.Checked = true;
            if (rbtCategoriaTurista.Checked)
            {
                rbtCategoriaTurista.Checked = false;
            }
        }

        private void rbtCategoriaTurista_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCategoriaPremium.Checked && !rbtCategoriaTurista.Checked)
            {
                lblValorTotal.Text = (Math.Round(vueloSeleccionado.Costo * 1.15)).ToString();
            }
            else if (!rbtCategoriaPremium.Checked && rbtCategoriaTurista.Checked)
            {
                numPeso2.Enabled = false;
                lblValorTotal.Text = vueloSeleccionado.Costo.ToString();
            }
        }

        private void LimpiarRbt()
        {
            rbtCategoriaTurista.Checked = false;
            rbtCategoriaPremium.Checked = false;
        }

        private void CargarDatosVueloElegido()
        {
            indiceDestinos = Registro.GetIndex(vueloSeleccionado.Destino);

            txtMatricula.Clear();
            txtMatricula.Text = vueloSeleccionado.MatriculaAvion;
            cmbDestinos.SelectedIndex = indiceDestinos;
            lblValorTotal.Text = vueloSeleccionado.Costo.ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botonesOpciones = MessageBoxButtons.OK;
            DialogResult result;
            int idVuelo;
            int cantidadValijas = CalcularValijas();
            float valorPasajeNeto;
            float.TryParse(lblValorTotal.Text, out valorPasajeNeto);

            try
            {
                idVuelo = vueloSeleccionado.GetHashCode();
                if (Administracion.CheckearSiVueloExiste(idVuelo))
                {
                    if (EstanLosCamposLlenos())
                    {
                        if (Administracion.AgregarPasajeALista(vueloSeleccionado, clienteAtendido.Nombre, cantidadValijas, clienteAtendido.Dni, indiceDestinos, valorPasajeNeto, rbtCategoriaPremium.Checked, vueloSeleccionado.EsInternacional, rbtBolsoSi.Checked))
                        {

                            result = MessageBox.Show("Vuelo agregado con exito!", "", botonesOpciones);

                            if (result == DialogResult.OK)
                            {
                                Close();
                                foreach(Pasaje pasaje in vueloSeleccionado.ListaPasajes)
                                {
                                    MessageBox.Show(pasaje.ToString(), "", botonesOpciones);
                                    if (result == DialogResult.OK)
                                    {
                                        Close();
                                    }
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
                        throw new Exception("El Vuelo no existe en nuestros registros");
                    }

                }
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }

        private int CalcularValijas()
        {
            if (numPeso1.Value > 0 && numPeso2.Value > 0)
            {
                return 2;
            }
            else if (numPeso1.Value > 0 && !numPeso2.Enabled)
            {
                return 1;
            }
            throw new Exception("Tiene que llevar al menos una Valija");
        }

        private bool EstanLosCamposLlenos()
        {
            if (rbtBolsoNo.Checked || rbtBolsoSi.Checked)
            {
                if (rbtCategoriaPremium.Checked || rbtCategoriaTurista.Checked)
                {
                    if (numPeso1.Value != 0)
                    {
                        if (txtMatricula.Text != string.Empty)
                        {
                            return true;
                        }
                        throw new Exception("Debe primero elegir el vuelo de la lista");
                    }
                    throw new Exception("Debe ingresar al menos el peso de una valija");
                }
                throw new Exception("No ha seleccionado ninguna categoria de vuelo");
            }
            throw new Exception("Debe indicar si llevara bolsos");
        }
    }
}
