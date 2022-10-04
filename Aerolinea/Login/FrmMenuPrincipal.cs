﻿using Entidades;
using System;
using System.Windows.Forms;
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
            DateTime fechaActual = DateTime.Now.Date;

            lblFechaActual.Text += fechaActual.ToShortDateString();

            lblTituloMenu.Text += vendedorDeTurno.NombreApellido();

            MostrarClientes();
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmRegistroPasajero menu = new(vendedorDeTurno);

            menu.ShowDialog();
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            if (lstPasajeros.Items.Count > 0)
            {
                lstPasajeros.Items.Clear();
            }

            foreach (Persona persona in Registro.Personas)
            {
                if (persona is Cliente cliente)
                {
                    lstPasajeros.Items.Add(cliente);

                }
            }
        }


        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
          if (Registro.Pasajes.Count > 0)
            {
            FrmHistorial menu = new();

            menu.ShowDialog();
            MostrarClientes();
            }
            else
            {
                lblErrores.Text = "No hay pasajes vendidos";
            }
        }

        private void btnGestionPasaje_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstPasajeros.Items.Count > 0 && lstPasajeros.SelectedItems.Count != 0)
                {
                    if (Registro.Vuelos.Count > 0)
                    {
                        Cliente clienteSeleccionado = (Cliente)lstPasajeros.SelectedItem;

                        FrmVentaPasajes menu = new(clienteSeleccionado);

                        menu.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("No hay vuelos cargados en el sistema");
                    }
                }
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
            lstPasajeros.Items.Clear();
            MostrarClientes();
        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            FrmRegistroVuelo menu = new();

            menu.ShowDialog();
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

        private void btnAltaAviones_Click(object sender, EventArgs e)
        {
            FrmAltaAviones menu = new();

            menu.ShowDialog();
        }
    }


}
