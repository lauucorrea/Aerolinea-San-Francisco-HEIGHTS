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
using Serializacion;

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
            try
            {

            rchMuestreo.Clear();
            string recaudacionTotal = Administracion.CalcularRecaudacion();
            rchMuestreo.AppendText(recaudacionTotal);
            }
            catch(Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }

        private void btnPasajerosPorVuelo_Click(object sender, EventArgs e)
        {
            try
            {

            rchMuestreo.Clear();
            string PasajerosOrdenadosPorVuelo = Administracion.ObtenerPasajerosPorVuelo();
            rchMuestreo.AppendText(PasajerosOrdenadosPorVuelo);
            }
            catch(Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            try
            {
            Administracion.ActualizarFacturacionesPorDestino();
            FrmHistorialDestinos menu = new(Registro.DiccionarioDestinos);

            menu.ShowDialog();

            }
            catch(Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }

        private void PasajerosFrecuentes_Click(object sender, EventArgs e)
        {
            try
            {

            VerPasajerosFrecuentes();
            }catch(Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
            
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
                Clase_serializadora serializadora = new();
                serializadora.GuardarPersonasXML();
                Application.Exit();
            }
        }

        private void VerPasajerosFrecuentes()
        {
            if(Registro.Personas.Count > 0)
            {
            List<Cliente> listaClientes = new();
            foreach (Persona persona in Registro.Personas)
            {
                if (persona is Cliente cliente)
                {
                    listaClientes.Add(cliente);
                }
            }
            FrmPasajerosFrecuentes menu = new(listaClientes);

            menu.ShowDialog();

            }
            else
            {
                throw new Exception("No hay personas registradas");
            }
        }
    }
}
