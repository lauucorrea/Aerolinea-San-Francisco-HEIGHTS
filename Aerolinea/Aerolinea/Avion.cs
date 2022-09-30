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
        private int capacidadBodega;
        private int totalAsientos;
        private string matriculaAvion;

        public Avion(bool ofreceComida, int cantidadDeToilets, int capacidadBodega, int totalAsientos, string matriculaAvion)
        {
            OfreceComida = ofreceComida;
            CantidadDeToilets = cantidadDeToilets;
            CapacidadBodega = capacidadBodega;
            TotalAsientos = totalAsientos;
            MatriculaAvion = matriculaAvion;
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
                int numeroConvertido;
                if (int.TryParse(value.ToString(), out numeroConvertido))
                {
                    cantidadDeToilets = value;
                }
                else
                {
                    throw new Exception("Formato de la cantidad de toilets incorrecto");
                }
            }
        }

        public int CapacidadBodega
        {
            get => capacidadBodega;
            private set
            {
                int numeroConvertido;
                if (int.TryParse(value.ToString(), out numeroConvertido))
                {
                    capacidadBodega = value;
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
                    totalAsientos = value;
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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Ofrece Comida? {OfreceComida}- Capacidad Bodega: {CapacidadBodega}- Total Asientos: {TotalAsientos}-Matricula: {MatriculaAvion}");

            return sb.ToString();
        }
    }
}
