using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace Vista
{
    public partial class FrmHistorialDestinos : Form
    {
        DataTable historialDestinos;
        DataView historialDestinosDataview;
        Dictionary<Destinos, float> dictDestinos;
        public FrmHistorialDestinos(Dictionary<Destinos, float> diccionario)
        {
            InitializeComponent();
            dictDestinos = diccionario;
        }

        private void FrmHistorialDestinos_Load(object sender, EventArgs e)
        {
            DibujarTabla();
        }

        /// <summary>
        /// Muestra el datagrid con lo recaudado hasta el momento segun su destino
        /// </summary>
        private void DibujarTabla()
        {
            historialDestinos = new DataTable();
            historialDestinosDataview = new DataView();

            historialDestinos.Columns.Add("Destino", typeof(string));
            historialDestinos.Columns.Add("Recaudo", typeof(float));

            foreach (var d in dictDestinos)
            {
                if (d.Value > 0)
                {

                    string nombreDestino = d.Key.ToString();
                    float valor = d.Value;

                    historialDestinos.Rows.Add(nombreDestino, valor);
                }

            }

            dtgDestinos.DataSource = historialDestinos;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
