using Entidades;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
namespace Vista
{
    public partial class FrmVentaPasajes : Form
    {
        Cliente? clienteAtendido = null;
        Cliente? clienteLogueado = null;
        Vendedor? vendedorLogueado = null;
        Vuelo? vueloSeleccionado = null;
        DataTable vuelosDisponibles = new();
        Type? tipoVendedor = null;
        int indiceDestinos;
        private FrmVentaPasajes()
        {
            InitializeComponent();
        }
        //chequear si el vendedor de turno se esta autovendiendo un pasaje
        public FrmVentaPasajes(Cliente clienteElegido, Persona vendedorDeTurno, Type vendedor) : this()
        {
            clienteAtendido = clienteElegido;
            tipoVendedor = vendedor;
            if (vendedor == typeof(Cliente))
            {
                clienteLogueado = (Cliente)vendedorDeTurno;
            }
            else if (vendedor == typeof(Vendedor))
            {
                vendedorLogueado = (Vendedor)vendedorDeTurno;
            }
        }

        private void FrmVentaPasajes_Load(object sender, EventArgs e)
        {
            try
            {

                if (clienteAtendido is not null)
                {
                    DibujarTabla();
                    txtNombre.Text = clienteAtendido.Nombre;
                    txtDni.Text = clienteAtendido.Dni.ToString();

                    txtDni.ReadOnly = true;
                    rbtCategoriaTurista.Checked = true;
                    rbtBolsoNo.Checked = true;
                    EvaluarCampos();
                }
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }

        }
        private void DibujarTabla()
        {
            vuelosDisponibles = new DataTable();

            vuelosDisponibles.Columns.Add("Origen", typeof(string));
            vuelosDisponibles.Columns.Add("Destino", typeof(Destinos));
            vuelosDisponibles.Columns.Add("Partida", typeof(DateTime));
            vuelosDisponibles.Columns.Add("Llegada", typeof(DateTime));
            vuelosDisponibles.Columns.Add("Costo", typeof(float));
            vuelosDisponibles.Columns.Add("Asientos Premium", typeof(int));
            vuelosDisponibles.Columns.Add("Asientos Turista", typeof(int));
            vuelosDisponibles.Columns.Add("Total Asientos", typeof(int));
            vuelosDisponibles.Columns.Add("Matricula avion", typeof(string));

            foreach (Vuelo vuelo in Registro.Vuelos)
            {
                vuelosDisponibles.Rows.Add(
                    vuelo.Origen,
                    vuelo.Destino,
                    vuelo.HoraPartida,
                    vuelo.HoraLlegada,
                    vuelo.Costo,
                    vuelo.AsientosPremium,
                    vuelo.AsientosTurista,
                    vuelo.AvionVuelo.TotalAsientos,
                    vuelo.AvionVuelo.MatriculaAvion);

            }

            dtgVuelos.DataSource = vuelosDisponibles;

            dtgVuelos.Rows[0].Selected = true;
            vueloSeleccionado = Registro.Vuelos[0];
            CargarDatosVueloElegido();
        }

        private void CargarDatosVueloElegido()
        {
            if (vueloSeleccionado is not null)
            {
                indiceDestinos = (int)vueloSeleccionado.Destino;

                txtMatricula.Clear();
                txtMatricula.Text = vueloSeleccionado.AvionVuelo.MatriculaAvion;
                cmbDestinos.DataSource = Enum.GetValues(typeof(Destinos));
                cmbDestinos.SelectedIndex = indiceDestinos;
                cmbDestinos.Enabled = false;
                lblValorTotal.Text = vueloSeleccionado.Costo.ToString();

            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botonesOpciones = MessageBoxButtons.OK;
            DialogResult result;
            int cantidadValijas;
            decimal pesoValijas = Math.Round(numPeso1.Value + numPeso2.Value, 2);
            string stringPasajeFinal;
            try
            {
                float.TryParse(lblValorTotal.Text, out float valorPasajeNeto);

                if (Administracion.CheckearSiVueloExiste(vueloSeleccionado))
                {
                    if (EstanLosCamposLlenos() && vueloSeleccionado is not null)
                    {
                        if (vueloSeleccionado.AvionVuelo.PuedeCargarValijas(pesoValijas))
                        {
                            if (vueloSeleccionado.GestionarAsientos(rbtCategoriaPremium.Checked))
                            {
                                stringPasajeFinal = CalcularPrecioFinal(valorPasajeNeto, out float valorPasajeFinal);
                                rchCostoTotal.Text = stringPasajeFinal;

                                result = MessageBox.Show("Concretar Venta?", "", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes && clienteAtendido is not null)
                                {
                                    cantidadValijas = CalcularValijas();
                                    vueloSeleccionado.AvionVuelo.CargaActualBodega += pesoValijas;
                                    if (Administracion.AgregarPasajeALista(vueloSeleccionado, clienteAtendido.Nombre, cantidadValijas, clienteAtendido.Dni, indiceDestinos, (float)Math.Round(valorPasajeFinal, 2), rbtCategoriaPremium.Checked, vueloSeleccionado.EsInternacional, rbtBolsoSi.Checked))
                                    {
                                        vueloSeleccionado.AsientosOcupados++;

                                        if (tipoVendedor == typeof(Cliente))
                                        {
                                            clienteAtendido.CantidadVuelosComprados++;
                                            clienteAtendido.GestionarCategoria();
                                        }
                                        else if (vendedorLogueado is not null)
                                        {
                                            vendedorLogueado.CantidadVuelosVendidos++;
                                            clienteAtendido.CantidadVuelosComprados++;
                                            clienteAtendido.GestionarCategoria();
                                            vendedorLogueado.GestionarCategoria();
                                        }
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

            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }

        private string CalcularPrecioFinal(float valorNeto, out float precioFinal)
        {
            float valorPasajeFinal = valorNeto;
            float iva = valorNeto * 0.15f;
            float impuestoAccesorios = valorNeto * 0.2f;
            float impuestoPais = valorNeto * 0.8f;
            float impuestoAgua = valorNeto * 0.1f;
            float impuestoAlAsiento = valorNeto * 0.5f;
            float descuentoCategoria = 0;


            if (clienteAtendido is not null)
            {
                valorPasajeFinal += iva + impuestoAccesorios + impuestoAgua + impuestoAlAsiento + impuestoPais;

                switch (clienteAtendido.Categoria.ToString())
                {
                    case "Primerizo":
                        descuentoCategoria = 0.10f;
                        valorPasajeFinal -= valorPasajeFinal * descuentoCategoria;
                        descuentoCategoria = 10;
                        break;
                    case "Regular":
                        descuentoCategoria = 0.20f;
                        valorPasajeFinal -= valorPasajeFinal * descuentoCategoria;
                        descuentoCategoria = 20;
                        break;
                    case "VIP":
                        descuentoCategoria = 0.30f;
                        valorPasajeFinal -= valorPasajeFinal * descuentoCategoria;
                        descuentoCategoria = 30;
                        break;
                }

                precioFinal = valorPasajeFinal;
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Valor neto del vuelo: {valorNeto}");
                sb.AppendLine($"+IVA 15%: {iva}");
                sb.AppendLine($"+Impuesto por accesorios 20%: {impuestoAccesorios}");
                sb.AppendLine($"+ImpuestoPais 80%: {impuestoPais}");
                sb.AppendLine($"+Impuesto por uso de agua 10%: {impuestoAgua}");
                sb.AppendLine($"+Impuesto al asiento ocupado 50%: {impuestoAlAsiento}");
                if (descuentoCategoria != 0)
                {

                    sb.AppendLine($"DESCUENTO POR CATEGORIA {clienteAtendido.Categoria} VALOR DESCUENTO: {descuentoCategoria}%");
                }
                sb.AppendLine($"############################################");
                sb.AppendLine($"PRECIO FINAL VUELO: {valorPasajeFinal}");

                return sb.ToString();

            }
            else
            {
                throw new Exception("El cliente atendido no es valido");
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
            if (rbtCategoriaPremium.Checked && vueloSeleccionado is not null)
            {
                lblValorTotal.Text = Math.Round((vueloSeleccionado.Costo * 1.15), 2).ToString();
                numPeso2.Enabled = true;
            }
            else if (rbtCategoriaTurista.Checked && vueloSeleccionado is not null)
            {
                numPeso2.Enabled = false;
                lblValorTotal.Text = vueloSeleccionado.Costo.ToString();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgVuelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dtgVuelos.CurrentRow.Index;
            dtgVuelos.Rows[indice].Selected = true;
            vueloSeleccionado = Registro.Vuelos[indice];
            CargarDatosVueloElegido();

        }
    }
}
