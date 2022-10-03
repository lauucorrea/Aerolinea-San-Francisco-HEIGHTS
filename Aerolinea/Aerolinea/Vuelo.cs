﻿using System;
using System.Collections.Generic;
using System.Text;
using Validaciones;
namespace Entidades
{

    public class Vuelo
    {
        private List<Pasaje> listaPasajes;
        private Avion avionVuelo;
        private bool esInternacional;
        private string origen;
        private static int idVuelo;
        private int asientosOcupados;
        private int asientosPremium;
        private int asientosTurista;
        private float costo;
        private Destinos destino;
        private DateTime horaPartida;
        private DateTime horaLlegada;

        static Vuelo()
        {
            IdVuelo = 0000;
        }

        public Vuelo(Avion avionVuelo, string origen, DateTime horaPartida, DateTime horaLlegada, Destinos destino, bool esInternacional, float costo)
        {
            ListaPasajes = new List<Pasaje>();
            AsientosOcupados = 0;
            Origen = origen;
            Destino = destino;
            EsInternacional = esInternacional;
            HoraPartida = horaPartida;
            HoraLlegada = horaLlegada;
            Costo = costo;
            IdVuelo = IdVuelo++;
            AvionVuelo = avionVuelo;
            CalcularAsientos();
        }
        #region setters/getters

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

        public Destinos Destino
        {
            get => destino;
            private set
            {
                destino = value;

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

        public Avion AvionVuelo
        {
            get
            {
                if (avionVuelo is not null)
                {
                    return avionVuelo;
                }
                throw new NullReferenceException();
            }
            private set
            {
                if (value is not null)
                {
                    avionVuelo = value;
                }
            }
        }

        public float Costo
        {
            get => costo;
            private set
            {
                float numConvertido;
                if (value > 0)
                {
                    if (float.TryParse(value.ToString(), out numConvertido))
                    {
                        costo = (float)Math.Round((double)numConvertido, 2);
                    }

                }
                else
                {
                    throw new Exception("El vuelo no puede salir gratis");
                }

            }
        }
        public bool EsInternacional
        {
            get => esInternacional;
            set => esInternacional = value;
        }

        public int AsientosPremium
        {
            get => asientosPremium;
            set
            {
                if (value >= 0)
                {
                    asientosPremium = value;
                }
                else
                {

                    throw new Exception("No se pueden cargar valores menores a 0");
                }
            }
        }
        public int AsientosTurista
        {
            get => asientosTurista;
            set
            {
                if (value >= 0)
                {
                    asientosTurista = value;
                }
                else
                {
                    throw new Exception("No se pueden cargar valores menores a 0");
                }

            }
        }

        public int AsientosOcupados
        {
            get => asientosOcupados;
            set
            {
                asientosOcupados = value;
            }
        }
        #endregion

        #region sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Origen: {Origen}  Destino: {Destino} Partida: {HoraPartida.ToString("HH:mm")} Llegada: {HoraLlegada.ToString("HH:mm")} Costo: ${Costo} ");
            sb.AppendLine($"EspaciosPremium {AsientosPremium} Espacios Turista: {asientosTurista} Total Asientos: {avionVuelo.TotalAsientos}  Matricula Avion: {AvionVuelo.MatriculaAvion}");
            
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return IdVuelo;
        }

        #endregion



        internal void CalcularAsientos()
        {
            int totalAsientos = AvionVuelo.TotalAsientos;
            if (totalAsientos != 0)
            {
                AsientosPremium = (int)Math.Round(totalAsientos * 0.20);
                AsientosTurista = totalAsientos - asientosPremium;
                return;
            }
            throw new Exception("El avion no tiene asientos");

        }

        public bool GestionarAsientos(bool esPremium)
        {
            int cantidadProxima;
            if (esPremium)
            {
                cantidadProxima = AsientosPremium - 1;
                if (cantidadProxima >= 0)
                {
                    AsientosPremium = cantidadProxima;
                    return true;
                }
                throw new Exception("No hay lugares disponibles");
            }
            else
            {
                cantidadProxima = AsientosTurista--;
                if (cantidadProxima >= 0)
                {
                    AsientosTurista = cantidadProxima;
                    return true;
                }
                throw new Exception("No hay lugares disponibles");
            }


        }




    }

}
