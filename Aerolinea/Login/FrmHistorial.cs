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
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVerRecaudacion_Click(object sender, EventArgs e)
        {
            rchMuestreo.Clear();
            string recaudacionTotal = Administracion.CalcularRecaudacion();
            rchMuestreo.AppendText(recaudacionTotal);
        }

        private void btnPasajerosPorVuelo_Click(object sender, EventArgs e)
        {
            rchMuestreo.Clear();
            string PasajerosOrdenadosPorVuelo = Administracion.ObtenerPasajerosPorVuelo();
            rchMuestreo.AppendText(PasajerosOrdenadosPorVuelo);
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            Administracion.ActualizarFacturacionesPorDestino();
            FrmHistorialDestinos menu = new FrmHistorialDestinos(Registro.DiccionarioDestinos);

            menu.ShowDialog();
        }

        private void PasajerosFrecuentes_Click(object sender, EventArgs e)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            foreach(Persona persona in Registro.Personas)
            {
                if (persona is Cliente)
                {
                    listaClientes.Add((Cliente)persona);
                }
            }
            FrmPasajerosFrecuentes menu = new FrmPasajerosFrecuentes(listaClientes);

            menu.ShowDialog();
        }

        private void btnAviones_Click(object sender, EventArgs e)
        {
             rchMuestreo.Clear();
             rchMuestreo.AppendText(Administracion.MostrarHorasDeVueloAeronave());

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
