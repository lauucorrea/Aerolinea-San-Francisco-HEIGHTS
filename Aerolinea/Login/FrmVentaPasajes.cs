using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace Vista
{
    public partial class FrmVentaPasajes : Form
    {
        Cliente clienteAtendido;
        Vuelo vueloSeleccionado;
        private FrmVentaPasajes()
        {
            InitializeComponent();
        }

        public FrmVentaPasajes(Cliente clienteElegido):this()
        {
            clienteAtendido = clienteElegido;
        }

        private void FrmVentaPasajes_Load(object sender, EventArgs e)
        {
            cmbDestino.DataSource = Enum.GetValues(typeof(Destinos));
            txtNombre.Text = clienteAtendido.Nombre;
            txtDni.Text = clienteAtendido.Dni.ToString();
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
            if(lstVuelos.SelectedItem is not null)
            {
                txtMatricula.Clear();
                vueloSeleccionado = (Vuelo)lstVuelos.SelectedItem;
                txtMatricula.Text = vueloSeleccionado.MatriculaAvion;
                lblValorTotal.Text = vueloSeleccionado.Costo.ToString();
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
            if(rbtCategoriaPremium.Checked && !rbtCategoriaTurista.Checked)
            {
                lblValorTotal.Text = (Math.Round(vueloSeleccionado.Costo * 1.15)).ToString();
            }
            else if(!rbtCategoriaPremium.Checked && rbtCategoriaTurista.Checked)
            {
                cmbValija2.Enabled = false;
                lblValorTotal.Text = vueloSeleccionado.Costo.ToString();
            }
        }

        private void LimpiarRbt()
        {
            rbtCategoriaTurista.Checked = false;
            rbtCategoriaPremium.Checked = false;
        }
    }
}
