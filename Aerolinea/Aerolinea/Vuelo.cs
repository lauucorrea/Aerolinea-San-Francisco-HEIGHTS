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
        private string origen;
        private string destino;
        private DateTime horaPartida;
        private DateTime horaLlegada;
        private List<Pasaje> listaPasajes;
        private float costo;
        private string matriculaAvion;

        public Vuelo(string origen,string destino, List<Pasaje> listaPasajes, float costo, string matriculaAvion)
        {
            Origen = origen;
            Destino = destino;
            HoraPartida = DateTime.Now;
            HoraLlegada = CrearHoraLlegada();
            ListaPasajes = listaPasajes;
            Costo = costo;
            MatriculaAvion = matriculaAvion;
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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Origen: {Origen}- Destino: {Destino}- Partida: {HoraPartida.ToString("HH:mm")}-Llegada: {HoraLlegada.ToString("HH:mm")}-Costo: ${Costo}-Matricula Avion: {MatriculaAvion}");

            return sb.ToString();
        }
        public string Destino
        {
            get => destino;
            private set
            {
                if (ValidadoraDeDatos.ValidarString(value.ToLower()))
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
            set
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

        public DateTime CrearHoraLlegada()
        {
            
            Random numHoraRandomNacional = new Random();
            Random numHoraRandomInternacional = new Random();
            Random minutos = new Random();

            int numeroNacional = numHoraRandomNacional.Next(2,4);
            int numeroInternacional = numHoraRandomInternacional.Next(8,12);

            DateTime horaLlegadaNacional = HoraPartida.AddHours(numeroNacional);
            
            return horaLlegadaNacional;
            
        }
    }

}
