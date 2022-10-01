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
            MostrarVuelos();

            txtNombre.Text = clienteAtendido.Nombre;
            txtDni.Text = clienteAtendido.Dni.ToString();

            txtDni.ReadOnly = true;
            rbtCategoriaTurista.Checked = true;
            rbtBolsoNo.Checked = true;
            EvaluarCampos();
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
            if (lstVuelos.SelectedItem is not null)
            {
                vueloSeleccionado = (Vuelo)lstVuelos.SelectedItem;
                CargarDatosVueloElegido();

            }

        }

        private void CargarDatosVueloElegido()
        {
            indiceDestinos = Registro.GetIndex(vueloSeleccionado.Destino);

            txtMatricula.Clear();
            txtMatricula.Text = vueloSeleccionado.AvionVuelo.MatriculaAvion;
            cmbDestinos.DataSource = Enum.GetValues(typeof(Destinos));
            cmbDestinos.SelectedIndex = indiceDestinos;
            cmbDestinos.Enabled = false;
            lblValorTotal.Text = vueloSeleccionado.Costo.ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botonesOpciones = MessageBoxButtons.OK;
            DialogResult result;
            int cantidadValijas;
            decimal pesoValijas = Math.Round(numPeso1.Value + numPeso2.Value, 2);
            decimal valorPasajeNeto;

            try
            {
                decimal.TryParse(lblValorTotal.Text, out valorPasajeNeto);
                if (Administracion.CheckearSiVueloExiste(vueloSeleccionado))
                {
                    if (EstanLosCamposLlenos())
                    {
                        cantidadValijas = CalcularValijas();
                        if (Administracion.AvionPuedeCargarValijas(vueloSeleccionado.AvionVuelo, pesoValijas))
                        {
                            if (vueloSeleccionado.GestionarAsientos(rbtCategoriaPremium.Checked))
                            {
                                vueloSeleccionado.AvionVuelo.CargaActualBodega += pesoValijas;
                                if (Administracion.AgregarPasajeALista(vueloSeleccionado, clienteAtendido.Nombre, cantidadValijas, clienteAtendido.Dni, indiceDestinos, Math.Round(valorPasajeNeto, 2), rbtCategoriaPremium.Checked, vueloSeleccionado.EsInternacional, rbtBolsoSi.Checked))
                                {
                                    result = MessageBox.Show("Pasaje agregado con exito!", "", botonesOpciones);

                                    if (result == DialogResult.OK)
                                    {
                                        Close();
                                    }
                                }
                            }
                        }
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
            if (numPeso1.Value >= 0 && numPeso2.Value >= 0)
            {
                return 2;
            }
            else if (numPeso1.Value >= 0 && !numPeso2.Enabled)
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

        private void EvaluarCampos()
        {
            if ((rbtBolsoNo.Checked || rbtBolsoSi.Checked) && (rbtCategoriaPremium.Checked || rbtCategoriaTurista.Checked) && !string.IsNullOrEmpty(txtMatricula.Text))
            {
                btnVender.Enabled = true;
            }
        }

        private void cmbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EvaluarCampos();
        }

        private void numPeso1_ValueChanged(object sender, EventArgs e)
        {
            EvaluarCampos();
        }

        private void numPeso2_ValueChanged(object sender, EventArgs e)
        {
            EvaluarCampos();
        }

        private void rbtBolsoSi_CheckedChanged(object sender, EventArgs e)
        {
            EvaluarCampos();
        }

        private void rbtBolsoNo_CheckedChanged(object sender, EventArgs e)
        {
            EvaluarCampos();
        }

        private void rbtCategoriaTurista_CheckedChanged(object sender, EventArgs e)
        {
            EvaluarCampos();
            if (rbtCategoriaPremium.Checked)
            {
                lblValorTotal.Text = Math.Round((vueloSeleccionado.Costo * 1.15),2).ToString();
                numPeso2.Enabled = true;
            }
            else if (rbtCategoriaTurista.Checked)
            {
                numPeso2.Enabled = false;
                lblValorTotal.Text = vueloSeleccionado.Costo.ToString();
            }
        }
    }
}
