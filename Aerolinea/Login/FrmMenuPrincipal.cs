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
using Vista;
namespace Login
{
    public partial class FrmMenuPrincipal : Form
    {
        Vendedor vendedorDeTurno;
        
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public FrmMenuPrincipal(Vendedor vendedorLogueado) : this()
        {
            vendedorDeTurno = vendedorLogueado;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblTituloMenu.Text += vendedorDeTurno.NombreApellido();
            MostrarClientes();
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmRegistroPasajero menu = new FrmRegistroPasajero(vendedorDeTurno);
            
            menu.ShowDialog();
        }

        private void MostrarClientes()
        {
            if (lstPasajeros.Items.Count > 0)
            {
                lstPasajeros.Items.Clear();
            }

            foreach (Persona persona in Registro.Personas)
            {
                if(persona is Cliente)
                {
                    lstPasajeros.Items.Add((Cliente)persona);

                }
            }
        }


        private void btnVerHistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionPasaje_Click(object sender, EventArgs e)
        {
            if(lstPasajeros.Items.Count > 0 && lstPasajeros.SelectedItems.Count != 0)
            {
                Cliente clienteSeleccionado = (Cliente)lstPasajeros.SelectedItem;

                FrmVentaPasajes menu = new FrmVentaPasajes(clienteSeleccionado);

                menu.ShowDialog();
            }
            

        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            FrmRegistroVuelo menu = new FrmRegistroVuelo();

            menu.ShowDialog();
        }
    }
}
