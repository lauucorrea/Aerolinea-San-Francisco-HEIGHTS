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
        private Enum destino;
        private float valorPasaje;
        private bool esPremium;
        private bool esInternacional;
        private string matriculaAvion;
        private bool traeBolsos;
        private int cantidadValijas;

        public Pasaje(string nombrePasajero, int dniPasajero, Enum destino, float valorPasaje, bool esPremium, bool esInternacional, string matriculaAvion, bool traeBolsos, int cantidadValijas)
        {
            NombrePasajero = nombrePasajero;
            DniPasajero = dniPasajero;
            Destino = destino;
            ValorPasaje = valorPasaje;
            EsPremium = esPremium;
            EsInternacional = esInternacional;
            MatriculaAvion = matriculaAvion;
            TraeBolsos = traeBolsos;
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
        public Enum Destino
        {
            get => destino;
            private set
            {
                if (value is not null)
                {
                    destino = (Destinos)value;
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }
        public float ValorPasaje
        {
            get => valorPasaje;
            private set
            {
                if (value > 0)
                {
                    valorPasaje = value;
                }
                else
                {
                    throw new Exception("El valor del pasaje es invalido");
                }
            }
        }

        public bool EsPremium
        {
            get => esPremium;
            private set => esPremium = value;
        }

        public bool EsInternacional
        {
            get => esInternacional;
            private set => esInternacional = value;
        }

        public bool TraeBolsos
        {
            get => traeBolsos;
            private set => traeBolsos = value;
        }

        public string MatriculaAvion
        {
            get => matriculaAvion;
            private set
            {
                if (Administracion.CheckearSiAvionExiste(value))
                {
                    matriculaAvion = value;
                }
                else
                {
                    throw new Exception("La matricula del avion no existe");
                }
            }
        }

        public int CantidadValijas
        {
            get => cantidadValijas;
            private set
            {
                if (value <= 2 && value > 0)
                {
                    cantidadValijas = value;
                }
                else
                {
                    throw new Exception("Cantidad de valijas invalida");
                }
            }
        }
        // public Pasaje(string nombrePasajero, int dniPasajero, Enum destino, float valorPasaje, bool esPremium, bool esInternacional, string matriculaAvion, bool traeBolsos, int cantidadValijas)
        public override string ToString()
        {
            string esPremium = EsPremium ? "Premium" : "Turista";
            string esInternacional = EsInternacional ? "Internacional" : "Nacional";
            string traeBolsos = TraeBolsos ? "Si" : "No";
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre pasajero: {NombrePasajero} Dni: {DniPasajero} Destino : {Destino} Valor del pasaje: {ValorPasaje} Categoria: {esPremium} Alcance: {esInternacional} Valijas: {CantidadValijas} Bolsos: {traeBolsos} Avion: {MatriculaAvion} ");

            return sb.ToString();
        }
    }
}
