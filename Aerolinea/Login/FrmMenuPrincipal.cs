using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vista;
namespace Login
{
    public partial class FrmMenuPrincipal : Form
    {
        Type tipoPersonaLogueada;
        Vendedor vendedorLogueado;
        Cliente clienteLogueado;
        DataTable clientes = new();
        Cliente clienteSeleccionado;
        List<Cliente> listaClientes = new();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public FrmMenuPrincipal(Persona personaLogin) : this()
        {
            tipoPersonaLogueada = personaLogin.GetType();

            if (tipoPersonaLogueada == typeof(Vendedor))
            {
                vendedorLogueado = (Vendedor)personaLogin;
            }
            else if (tipoPersonaLogueada == typeof(Cliente))
            {
                clienteLogueado = (Cliente)personaLogin;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date;
            lblFechaActual.Text += fechaActual.ToShortDateString();
            
            if (tipoPersonaLogueada == typeof(Vendedor))
            {
                vendedorLogueado.GestionarCategoria();
                lblTituloMenu.Text += vendedorLogueado.NombreApellido();
                lblCategoria.Text = vendedorLogueado.Categoria.ToString();

            }
            else if (tipoPersonaLogueada == typeof(Cliente))
            {
                clienteLogueado.GestionarCategoria();
                lblTituloMenu.Text += clienteLogueado.NombreApellido();
                lblCategoria.Text = clienteLogueado.Categoria.ToString();
                btnVerHistorial.Enabled = false;
                btnAgregarCliente.Enabled = false;
                btnAgregarVuelo.Enabled = false;
                btnAltaAviones.Enabled = false;
            }

            DibujarTabla();
        }


        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRegistroPasajero menu = new(vendedorLogueado);

                menu.ShowDialog();
                DibujarTabla();

            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
        }
        private void DibujarTabla()
        {
            clientes = new DataTable();

            clientes.Columns.Add("Nombre", typeof(string));
            clientes.Columns.Add("Apellido", typeof(string));
            clientes.Columns.Add("Dni", typeof(int));
            clientes.Columns.Add("Edad", typeof(int));
            clientes.Columns.Add("Vuelos comprados", typeof(int));
            clientes.Columns.Add("Categoria", typeof(string));
            foreach (Persona persona in Registro.Personas)
            {
                if (persona is Cliente)
                {
                    Cliente cliente = (Cliente)persona;
                    cliente.GestionarCategoria();
                    listaClientes.Add(cliente);
                    string nombre = cliente.Nombre;
                    string apellido = cliente.Apellido;
                    int dni = cliente.Dni;
                    int edad = cliente.Edad;
                    int vuelosRegistrados = cliente.CantidadVuelosComprados;
                    string categoria = cliente.Categoria.ToString();
                    clientes.Rows.Add(nombre, apellido, dni, edad, vuelosRegistrados, categoria);
                }

            }
            dtgClientes.DataSource = clientes;
        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            if (Registro.Pasajes.Count > 0)
            {
                FrmHistorial menu = new();

                menu.ShowDialog();
                DibujarTabla();
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
                if (clienteSeleccionado is not null && dtgClientes.CurrentRow is not null)
                {
                    if (Registro.Vuelos.Count > 0)
                    {
                        if (tipoPersonaLogueada == typeof(Vendedor))
                        {
                            FrmVentaPasajes menu = new(clienteSeleccionado, vendedorLogueado, tipoPersonaLogueada);
                            menu.ShowDialog();
                        }
                        else if (tipoPersonaLogueada == typeof(Cliente))
                        {
                            if (clienteLogueado.Equals(clienteSeleccionado))
                            {
                                FrmVentaPasajes menu = new(clienteSeleccionado, clienteLogueado, tipoPersonaLogueada);
                                menu.ShowDialog();
                            }
                            else
                            {
                                lblErrores.Text = "Un cliente no puede venderle a otros clientes";
                            }
                        }
                        else
                        {
                            throw new Exception("tipo de persona no valida");
                        }
                    }
                    else
                    {
                        throw new Exception("No hay vuelos cargados en el sistema");
                    }
                }
                else
                {
                    throw new Exception("No hay un cliente seleccionado para operar");
                }
            }
            catch (Exception ex)
            {
                lblErrores.Text = ex.Message;
            }
            DibujarTabla();
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

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = dtgClientes.CurrentRow.Index;
            dtgClientes.Rows[indice].Selected = true;
            clienteSeleccionado = (Cliente)listaClientes[indice];
        }
    }


}
