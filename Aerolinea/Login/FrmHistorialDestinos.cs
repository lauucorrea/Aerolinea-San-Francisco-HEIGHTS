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
    public partial class FrmHistorialDestinos : Form
    {
        DataTable historialDestinos;
        DataView historialDestinosDataview;
        Dictionary<Destinos, float> dictDestinos;
        public FrmHistorialDestinos(Dictionary<Destinos,float> diccionario)
        {
            InitializeComponent();
            dictDestinos = diccionario;
        }

        private void FrmHistorialDestinos_Load(object sender, EventArgs e)
        {
            DibujarTabla();
        }

        private void dtgDestinos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DibujarTabla()
        {
            historialDestinos = new DataTable();
            historialDestinosDataview = new DataView();

            historialDestinos.Columns.Add("Destino", typeof(string));
            historialDestinos.Columns.Add("Recaudo", typeof(float));

            foreach (var d in dictDestinos)
            {
                string nombreDestino = d.Key.ToString();
                float valor = d.Value;

                historialDestinos.Rows.Add(nombreDestino,valor);

            }

            dtgDestinos.DataSource = historialDestinos;
        }



    }
}
