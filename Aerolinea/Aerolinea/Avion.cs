using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;
namespace Entidades
{
    public class Avion
    {
        private bool ofreceComida;
        private int cantidadDeToilets;
        private decimal capacidadBodega;
        private decimal cargaActualBodega;
        private int totalAsientos;
        private string matriculaAvion;

        public Avion(bool ofreceComida, int cantidadDeToilets, decimal capacidadBodega, int totalAsientos, string matriculaAvion)
        {
            OfreceComida = ofreceComida;
            CantidadDeToilets = cantidadDeToilets;
            CapacidadBodega = capacidadBodega;
            TotalAsientos = totalAsientos;
            MatriculaAvion = matriculaAvion;
            CargaActualBodega = 0;
        }
        #region setters/getters
        public bool OfreceComida
        {
            get => ofreceComida;
            private set => ofreceComida = value;
        }

        public int CantidadDeToilets
        {
            get => cantidadDeToilets;
            private set
            {
                int numeroConvertido;
                if (int.TryParse(value.ToString(), out numeroConvertido) && numeroConvertido > 0)
                {
                    cantidadDeToilets = numeroConvertido;
                }
                else
                {
                    throw new Exception("Formato de la cantidad de toilets incorrecto");
                }
            }
        }

        public decimal CapacidadBodega
        {
            get => capacidadBodega;
            private set
            {
                decimal numeroConvertido;
                if (decimal.TryParse(value.ToString(), out numeroConvertido) && numeroConvertido > 0)
                {
                    capacidadBodega = Math.Round(numeroConvertido, 2);
                }
                else
                {
                    throw new Exception("Formato de capacidad de bodega incorrecto");
                }
            }
        }
        public decimal CargaActualBodega
        {
            get => cargaActualBodega;
            set
            {
                decimal numeroConvertido;
                if (decimal.TryParse(value.ToString(), out numeroConvertido))
                {
                    if(value <= CapacidadBodega)
                    {
                        cargaActualBodega = Math.Round(numeroConvertido, 2);
                    }
                    else
                    {
                        throw new Exception("La carga actual superaria la capacidad del avion");
                    }
                   
                }
                else
                {
                    throw new Exception("Formato de capacidad de bodega incorrecto");
                }
            }
        }
        public int TotalAsientos
        {
            get => totalAsientos;
            private set
            {
                int numeroConvertido;
                if (int.TryParse(value.ToString(), out numeroConvertido))
                {
                    totalAsientos = numeroConvertido;
                }
                else
                {
                    throw new Exception("Formato de la cantidad de asientos incorrecto");
                }
            }
        }
        public string MatriculaAvion
        {
            get => matriculaAvion;
            private set
            {
                if (ValidadoraDeDatos.ValidarAlfanumerico(value))
                {
                    matriculaAvion = value;
                }
                else
                {
                    throw new Exception("Formato de matricula incorrecto");
                }
            }
        }
        #endregion
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Ofrece Comida? {OfreceComida}- Capacidad Bodega: {CapacidadBodega} Carga Actual: {CargaActualBodega}- Total Asientos: {TotalAsientos}-Matricula: {MatriculaAvion}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Avion avion = obj as Avion;

            return avion is not null && MatriculaAvion == avion.MatriculaAvion;
        }

       

    }
}
