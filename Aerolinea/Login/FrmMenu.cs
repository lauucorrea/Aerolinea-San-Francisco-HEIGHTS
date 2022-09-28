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
namespace Login
{
    public partial class FrmMenu : Form
    {
        Vendedor vendedorDeTurno;
        
        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(Vendedor vendedorLogueado) : this()
        {
            vendedorDeTurno = vendedorLogueado;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblTituloMenu.Text += vendedorDeTurno.NombreApellido();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string datosPasajero;
            if (lstPasajeros.Items.Count > 0)
            {
                lstPasajeros.Items.Clear();
            }


            foreach (Persona persona in Registro.Personas)
            {
                if(persona is Cliente)
                {
                   datosPasajero = ((Cliente)persona).ToString();
                   lstPasajeros.Items.Add(datosPasajero);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRegistroPasajero menu = new FrmRegistroPasajero(vendedorDeTurno);
            
            menu.ShowDialog();
        }
    }
}
