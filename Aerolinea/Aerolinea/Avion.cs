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
        private int horasDeVuelo;
        public Avion(bool ofreceComida, int cantidadDeToilets, decimal capacidadBodega, int totalAsientos, string matriculaAvion)
        {
            horasDeVuelo = 0;
            OfreceComida = ofreceComida;
            CantidadDeToilets = cantidadDeToilets;
            CapacidadBodega = capacidadBodega;
            TotalAsientos = totalAsientos;
            MatriculaAvion = matriculaAvion;
            CargaActualBodega = 0;
        }
        
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
                if (int.TryParse(value.ToString(), out int numeroConvertido) && numeroConvertido > 0)
                {
                    cantidadDeToilets = numeroConvertido;
                }
                else
                {
                    throw new Exception("Formato de la cantidad de toilets incorrecto");
                }
            }
        }
        public int HorasDeVuelo
        {
            get => horasDeVuelo;
            set => horasDeVuelo = value;
        }

        public decimal CapacidadBodega
        {
            get => capacidadBodega;
            private set
            {
                if (decimal.TryParse(value.ToString(), out decimal numeroConvertido) && numeroConvertido > 0)
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
                if (decimal.TryParse(value.ToString(), out decimal numeroConvertido))
                {
                    if (value <= CapacidadBodega)
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
                    throw new Exception("El peso tiene que ser un valor numerico");
                }
            }
        }
        public int TotalAsientos
        {
            get => totalAsientos;
            private set
            {
                if (int.TryParse(value.ToString(), out int numeroConvertido))
                {
                    totalAsientos = numeroConvertido;
                }
                else
                {
                    throw new Exception("La cantidad de asientos debe ser numerica");
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
                    throw new Exception("La matricula debe ser alfanumerica");
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new ();
            string ofrece;
            if (ofreceComida)
            {
                ofrece = "Si";
            }
            else
            {
                ofrece = "No";
            }

            sb.AppendLine($"Ofrece Comida? {ofrece} Capacidad Bodega: {CapacidadBodega}Kg Carga Actual: {CargaActualBodega}Kg");
            sb.AppendLine($"Total Asientos: {TotalAsientos} Matricula: {MatriculaAvion}");
            sb.AppendLine($"Horas de vuelo {HorasDeVuelo}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Avion avion = obj as Avion;

            return avion is not null && MatriculaAvion == avion.MatriculaAvion;
        }

        public override int GetHashCode()
        {
            return matriculaAvion.GetHashCode();
        }

        public bool PuedeCargarValijas(decimal pesoValijas)
        {
            decimal proximoPeso = CargaActualBodega + pesoValijas;
            if (this is not null)
            {
                if (proximoPeso <= CapacidadBodega)
                {
                    return true;
                }
                throw new Exception("La cantidad de peso a cargar Excede los limites del avion");
            }
            throw new Exception("El avion seleccionado es nulo");
        }


    }
}
