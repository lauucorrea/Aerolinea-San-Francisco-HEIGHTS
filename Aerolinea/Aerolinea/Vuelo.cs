using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;
namespace Entidades
{

    public class Vuelo
    {
        private bool esInternacional;
        private string origen;
        private Enum destino;
        private DateTime horaPartida;
        private DateTime horaLlegada;
        private List<Pasaje> listaPasajes;
        private float costo;
        private string matriculaAvion;
        private static int idVuelo;

        static Vuelo()
        {
            IdVuelo = 0000;
        }

        public Vuelo(string origen,DateTime horaPartida,DateTime horaLlegada, Enum destino, bool esInternacional, float costo, string matriculaAvion)
        {
            Origen = origen;
            Destino = destino;
            EsInternacional = esInternacional;
            HoraPartida = horaPartida;
            HoraLlegada = horaLlegada;
            Costo = costo;
            MatriculaAvion = matriculaAvion;
            IdVuelo = IdVuelo++;
            ListaPasajes = new List<Pasaje>();
        }
        
        public string Origen
        {
            get => origen;
            private set
            {
                if (ValidadoraDeDatos.ValidarString(value.ToLower()))
                {
                    origen = value;
                }

                else
                {
                    throw new Exception("Origen incorrecto");
                }

            }

        }
        
        public static int IdVuelo
        {
            get => idVuelo;
            private set => idVuelo = value;
        }

        public Enum Destino
        {
            get => destino;
            private set
            {
                if (value is not null)
                {
                    destino = value;
                }

                else
                {
                    throw new Exception("Destino incorrecto");
                }

            }

        }
        public DateTime HoraPartida
        {
            get => horaPartida;
            private set => horaPartida = value;
        }
        public DateTime HoraLlegada
        {
            get => horaLlegada;
            private set => horaLlegada = value;
        }

        public List<Pasaje> ListaPasajes
        {
            get => listaPasajes;
            private set
            {
                listaPasajes = value;
            }
        }

        public float Costo
        {
            get => costo;
            private set
            {
                costo = value;
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

        public bool EsInternacional
        {
            get => esInternacional;
            set => esInternacional = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Origen: {Origen}- Destino: {Destino}- Partida: {HoraPartida.ToString("HH:mm")}-Llegada: {HoraLlegada.ToString("HH:mm")}-Costo: ${Costo}-Matricula Avion: {MatriculaAvion}");

            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return IdVuelo;
        }




    }

}
