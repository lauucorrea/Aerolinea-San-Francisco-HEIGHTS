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
        /// <summary>
        /// Carga los aviones al listbox
        /// </summary>
        private void MostrarAviones()
        {
            if (lstAviones.Items.Count > 0)
            {
                lstAviones.Items.Clear();
            }

            lstAviones.DataSource = Registro.Aviones;

        }

        /// <summary>
        /// si se selecciona otro avion, se cargan los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                if (Administracion.AgregarVueloALista(avionSeleccionado, txtOrigen.Text, cmbDestinos.SelectedIndex,(int)numHora.Value, (int)numMinutos.Value))
                {
                    
                    result = MessageBox.Show("Vuelo agregado con exito!", "", botonesOpciones);
                    if (result == DialogResult.OK)
                    {
                        Close();
                        return true;
                    }
                }
            }
            else
            {
                throw new Exception("Los campos numericos deben ser completados");
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
                Application.Exit();
            }
        }
    }
}
