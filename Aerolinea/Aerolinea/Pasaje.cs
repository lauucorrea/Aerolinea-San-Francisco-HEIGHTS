using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;
namespace Entidades
{
    public class Pasaje
    {
        private string nombrePasajero;
        private int dniPasajero;
        private string destino;
        private float valorPasaje;
        private bool esPremium;
        private bool esInternacional;
        private string matriculaAvion;
        private int cantidadBolsos;
        private int cantidadValijas;

        public Pasaje()
        {

        }

        public Pasaje(string nombrePasajero, int dniPasajero, string destino, float valorPasaje, bool esPremium, bool esInternacional, string matriculaAvion, int cantidadBolsos, int cantidadValijas) : this()
        {
            NombrePasajero = nombrePasajero;
            DniPasajero = dniPasajero;
            this.destino = destino;
            ValorPasaje = valorPasaje;
            this.esPremium = esPremium;
            this.esInternacional = esInternacional;
            this.matriculaAvion = matriculaAvion;
            CantidadBolsos = cantidadBolsos;
            CantidadValijas = cantidadValijas;
        }

        public string NombrePasajero
        {
            get => nombrePasajero;
            private set
            {
                if (ValidadoraDeDatos.ValidarString(value.ToLower()))
                {
                    nombrePasajero = value;
                }

                else
                {
                    throw new Exception("Nombre del pasajero incorrecto");
                }
            }
        }

        public int DniPasajero
        {
            get => dniPasajero;
            private set
            {
                if (ValidadoraDeDatos.VerificarDni(value))
                {
                    dniPasajero = value;
                }
                else
                {
                    throw new Exception("DniPasajero incorrecto");
                }
            }
        }
        public float ValorPasaje
        {
            get => valorPasaje;
            private set
            {
                int valorConvertido;

                if (int.TryParse(value.ToString(), out valorConvertido))
                {
                    valorPasaje = value;
                }
                else
                {
                    throw new Exception("El valor del pasaje es invalido");
                }
            }
        }

        public int CantidadBolsos
        {
            get => cantidadBolsos;
            private set
            {
                int valorConvertido;

                if (int.TryParse(value.ToString(), out valorConvertido))
                {
                    cantidadBolsos = value;
                }
                else
                {
                    throw new Exception("Cantidad de bolsos invalida");
                }
            }
        }

        public int CantidadValijas
        {
            get => cantidadValijas;
            private set
            {
                int valorConvertido;

                if (int.TryParse(value.ToString(), out valorConvertido))
                {
                    cantidadValijas = value;
                }
                else
                {
                    throw new Exception("Cantidad de valijas invalida");
                }
            }


        }
    }
}
