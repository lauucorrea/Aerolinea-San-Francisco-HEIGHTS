using System;
using System.Text;
using Validaciones;
namespace Entidades
{
    public class Pasaje
    {
        private string nombrePasajero;
        private int dniPasajero;
        private Destinos destino;
        private float valorPasaje;
        private bool esPremium;
        private bool esInternacional;
        private string matriculaAvion;
        private bool traeBolso;
        private int cantidadValijas;

        public Pasaje(string nombrePasajero, int dniPasajero, Destinos destino, float valorPasaje, bool esPremium, bool esInternacional, string matriculaAvion, bool traeBolso, int cantidadValijas)
        {
            NombrePasajero = nombrePasajero;
            DniPasajero = dniPasajero;
            Destino = destino;
            ValorPasaje = valorPasaje;
            EsPremium = esPremium;
            EsInternacional = esInternacional;
            MatriculaAvion = matriculaAvion;
            TraeBolso = traeBolso;
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
        public Destinos Destino
        {
            get => destino;
            private set
            {
               destino = value;
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

        public bool TraeBolso
        {
            get => traeBolso;
            private set => traeBolso = value;
        }

        public string MatriculaAvion
        {
            get => matriculaAvion;
            private set
            {
                matriculaAvion = value;
            }
        }

        public int CantidadValijas
        {
            get => cantidadValijas;
            private set
            {
                if (value <= 2 && value >= 0)
                {
                    cantidadValijas = value;
                }
                else
                {
                    throw new Exception("Cantidad de valijas invalida");
                }
            }
        }
        
        public override string ToString()
        {
            string esPremium = EsPremium ? "Premium" : "Turista";
            string esInternacional = EsInternacional ? "Internacional" : "Nacional";
            string traeBolso = TraeBolso ? "Si" : "No";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre pasajero: {NombrePasajero} Dni: {DniPasajero}");
            sb.AppendLine($"Destino: {Destino} \nValor del pasaje: {ValorPasaje}");
            sb.AppendLine($"Categoria: {esPremium}\nAlcance: {esInternacional}");
            sb.AppendLine($"Valijas: {CantidadValijas}\nBolsos: {traeBolso}");
            sb.AppendLine($"Avion: { MatriculaAvion}");

            return sb.ToString();
        }
    }
}
