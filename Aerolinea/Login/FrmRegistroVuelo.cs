using Entidades;
using Serializacion;
using System;
using System.Data;
using System.Windows.Forms;
namespace Vista
{
    public partial class FrmRegistroVuelo : Form
    {
        Avion avionSeleccionado = null;
        DataTable avionesDisponibles = new();
        DataView viewAviones = new();
        public FrmRegistroVuelo()
        {
            InitializeComponent();
        }
        private void FrmRegistroVuelo_Load(object sender, EventArgs e)
        {
            cmbDestinos.DataSource = Enum.GetValues(typeof(Destinos));
            DibujarTabla();
            //MostrarAviones();
        }
        /// <summary>
        /// Carga los aviones al listbox
        /// </summary>
       /* private void MostrarAviones()
        {
            if (lstAviones.Items.Count > 0)
            {
                lstAviones.Items.Clear();
            }

            lstAviones.DataSource = Registro.Aviones;

        }*/
        private void DibujarTabla()
        {
            avionesDisponibles = new DataTable();

            avionesDisponibles.Columns.Add("Ofrece comida", typeof(bool));
            avionesDisponibles.Columns.Add("Capacidad bodega", typeof(decimal));
            avionesDisponibles.Columns.Add("Carga actual", typeof(decimal));
            avionesDisponibles.Columns.Add("Asientos", typeof(int));
            avionesDisponibles.Columns.Add("Matricula", typeof(string));
            avionesDisponibles.Columns.Add("Horas de vuelo", typeof(int));

            foreach (Avion avion in Registro.Aviones)
            {
                avionesDisponibles.Rows.Add(
                    avion.OfreceComida,
                    avion.CapacidadBodega,
                    avion.CargaActualBodega,
                    avion.TotalAsientos,
                    avion.MatriculaAvion,
                    avion.HorasDeVuelo);

            }

            dtgAviones.DataSource = avionesDisponibles;

            dtgAviones.Rows[0].Selected = true;
            txtMatricula.Text = Registro.Aviones[0].MatriculaAvion;
            txtOrigen.Text = "Argentina";
        }

        /// <summary>
        /// si se selecciona otro avion, se cargan los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       /* private void lstAviones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAviones.SelectedItem is not null)
            {
                txtOrigen.Text = "BuenosAires";
                txtMatricula.Clear();
                avionSeleccionado = (Avion)lstAviones.SelectedItem;
                txtMatricula.Text = avionSeleccionado.MatriculaAvion;

            }
        }*/

        private void btnCargarVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                CargarVuelo();
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }


        private bool CargarVuelo()
        {
            MessageBoxButtons botonesOpciones = MessageBoxButtons.OK;
            DialogResult result;


            if (numHora.Value != 0)
            {

                if (Administracion.AgregarVueloALista(avionSeleccionado, txtOrigen.Text, cmbDestinos.SelectedIndex, (int)numHora.Value, (int)numMinutos.Value))
                {

                    result = MessageBox.Show("Vuelo agregado con exito!", "", botonesOpciones);
                    if (result == DialogResult.OK)
                    {
                        return true;
                    }
                }
            }
            else
            {
                throw new Exception("Debe ingresar al menos el peso de una valija");
            }
            return false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
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

        private void dtgAviones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dtgAviones.CurrentRow.Index;
            dtgAviones.Rows[indice].Selected = true;
            Avion avionSeleccionado = Registro.Aviones[indice];

            txtMatricula.Text = avionSeleccionado.MatriculaAvion;
            txtOrigen.Text = "Argentina";
        }
    }
}
