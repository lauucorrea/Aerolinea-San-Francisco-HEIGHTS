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
    public partial class FrmPasajerosFrecuentes : Form
    {
        DataTable clientesFrecuentes;
        DataView clientesFrecuentesDataview;
        List<Cliente> clientesRecibidos;
        public FrmPasajerosFrecuentes(List<Cliente> listaClientes)
        {
            InitializeComponent();
            clientesRecibidos = listaClientes;
        }

        private void FrmPasajerosFrecuentes_Load(object sender, EventArgs e)
        {
            DibujarTabla();
        }
        private void DibujarTabla()
        {
            clientesFrecuentes = new DataTable();
            clientesFrecuentesDataview = new DataView();

            clientesFrecuentes.Columns.Add("Nombre", typeof(string));
            clientesFrecuentes.Columns.Add("Apellido", typeof(string));
            clientesFrecuentes.Columns.Add("Dni", typeof(int));
            clientesFrecuentes.Columns.Add("Edad", typeof(int));
            clientesFrecuentes.Columns.Add("Vuelos registrados", typeof(int));

            foreach (Cliente cliente in clientesRecibidos)
            {
                if (cliente.CantidadVuelosComprados > 0)
                {
                    string nombre = cliente.Nombre;
                    string apellido = cliente.Apellido;
                    int dni = cliente.Dni;
                    int edad = cliente.Edad;
                    int vuelosRegistrados = cliente.CantidadVuelosComprados;
                    clientesFrecuentes.Rows.Add(nombre, apellido,dni,edad,vuelosRegistrados);
                }

            }

            dtgPasajeros.DataSource = clientesFrecuentes ;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
