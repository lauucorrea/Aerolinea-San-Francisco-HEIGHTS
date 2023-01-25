using System;
using System.Collections.Generic;

namespace Entidades
{
    public enum Destinos
    {
        SantaRosa, Bariloche, Corrientes, Cordoba, Jujuy, Mendoza, Neuquen, Posadas, Iguazu, Salta, SantiagoDelEstero, Trelew, Tucuman, PuertoMadryn, Ushuaia, Recife, Roma, Acapulco, Miami
    }

    public static class Registro
    {
        private static List<Persona> ListaPersonas;
        private static List<Pasaje> ListaPasajes;
        private static List<Avion> ListaAviones;
        private static List<Vuelo> ListaVuelos;
        private static Dictionary<Destinos, float> diccionarioDestinos;
        static Registro()
        {
            ListaPersonas = new List<Persona>();
            ListaPasajes = new List<Pasaje>();
            ListaAviones = new List<Avion>();
            ListaVuelos = new List<Vuelo>();
            diccionarioDestinos = new Dictionary<Destinos, float>();
            HardcodeListas();
        }


        public static List<Pasaje> Pasajes
        {
            get => ListaPasajes;
            set => ListaPasajes = value;
        }


        public static Dictionary<Destinos, float> DiccionarioDestinos
        {
            get => diccionarioDestinos;
            set => diccionarioDestinos = value;
        }

        public static List<Persona> Personas
        {
            set => ListaPersonas = value;
            get => ListaPersonas;
        }
        
        public static List<Avion> Aviones
        {
            get => ListaAviones;
        }

        public static List<Vuelo> Vuelos
        {
            get => ListaVuelos;
            set => ListaVuelos = value;
        }

        public static void HardcodeListas()
        {
            //ListaPersonas.Add(new Vendedor("Lautaro", "Correa", 41080577, 24, "lau123", "asd123"));
            //ListaPersonas.Add(new Vendedor("silvina", "peruca", 41100224, 50, "tedije", "123"));

            //CrearClientes();
            CrearAviones();
            CrearVuelos();
            CrearPasajes();
            CargarFacturacionesPorDestino();
        }
        /// <summary>
        /// Inicializa los valores del diccionario en 0
        /// </summary>
        public static void CargarFacturacionesPorDestino()
        {
            foreach (Destinos destino in Enum.GetValues(typeof(Destinos)))
            {
                DiccionarioDestinos.Add(destino, 0);
            }
        }

        public static void CrearClientes()
        {
            ListaPersonas.Add(new Cliente("Familia", "Colombres", 41177224, 50, "familia", "colombres"));
            ListaPersonas.Add(new Cliente("Vencina", "Gentila", 49630423, 50, "vencina", "gentila"));
            ListaPersonas.Add(new Cliente("Gerardo", "Pedila", 41152245, 50, "gerardo", "pedila"));
            ListaPersonas.Add(new Cliente("Prodi", "Sarapa", 41100624, 50, "prodi", "sarapa"));
            ListaPersonas.Add(new Cliente("Montaner", "Cecilia", 41105244, 50, "montaner", "cecilia"));
        }

        public static void CrearAviones()
        {
            ListaAviones.Add(new Avion(true, 2, 50, 22, "A2E3DE5A"));
            ListaAviones.Add(new Avion(true, 1, 40, 5, "U73WE98W"));
            ListaAviones.Add(new Avion(false, 3, 110, 45, "O23SFF8E"));
            ListaAviones.Add(new Avion(false, 2, 50, 12, "2LS9384L"));
            ListaAviones.Add(new Avion(true, 2, 80, 60, "O0O25AFF"));
            ListaAviones.Add(new Avion(false, 1, 40, 30, "WE345FHI"));
            ListaAviones.Add(new Avion(true, 1, 45, 22, "QHO0E4F5"));
        }

        public static void CrearVuelos()
        {
            DateTime partida = new(2022, 10, 01, 22, 3, 0);
            DateTime Llegada = new(2022, 10, 01, 01, 22, 0);

            ListaVuelos.Add(new Vuelo(ListaAviones[0], "BuenosAires", partida, Llegada, Destinos.Mendoza, false, Administracion.CalcularCostoDelVuelo(false, 3)));
            ListaVuelos.Add(new Vuelo(ListaAviones[1], "BuenosAires", partida, Llegada, Destinos.Mendoza, false, Administracion.CalcularCostoDelVuelo(false, 3)));
            ListaVuelos.Add(new Vuelo(ListaAviones[2], "BuenosAires", partida, Llegada.AddHours(5), Destinos.Roma, true, Administracion.CalcularCostoDelVuelo(false, 8)));
            ListaVuelos.Add(new Vuelo(ListaAviones[3], "BuenosAires", partida, Llegada.AddHours(5), Destinos.Miami, true, Administracion.CalcularCostoDelVuelo(false, 8)));
            ListaVuelos.Add(new Vuelo(ListaAviones[4], "BuenosAires", partida, Llegada, Destinos.Mendoza, false, Administracion.CalcularCostoDelVuelo(false, 3)));
            ListaVuelos.Add(new Vuelo(ListaAviones[5], "BuenosAires", partida, Llegada.AddHours(5), Destinos.Acapulco, true, Administracion.CalcularCostoDelVuelo(false, 8)));
            ListaVuelos.Add(new Vuelo(ListaAviones[6], "BuenosAires", partida, Llegada, Destinos.Mendoza, false, Administracion.CalcularCostoDelVuelo(false, 3)));
        }

        public static void CrearPasajes()
        {
            Pasaje Pasaje0 = new("Montaner", 41105244, ListaVuelos[0].Destino, ListaVuelos[0].Costo, false, ListaVuelos[0].EsInternacional, ListaVuelos[0].AvionVuelo.MatriculaAvion, true, 1);
            Pasaje Pasaje1 = new("Familia", 41177224, ListaVuelos[1].Destino, ListaVuelos[1].Costo, true, ListaVuelos[1].EsInternacional, ListaVuelos[1].AvionVuelo.MatriculaAvion, true, 1);
            Pasaje Pasaje2 = new("Familia", 41177224, ListaVuelos[2].Destino, ListaVuelos[2].Costo, true, ListaVuelos[2].EsInternacional, ListaVuelos[2].AvionVuelo.MatriculaAvion, true, 0);
            Pasaje Pasaje3 = new("Vencina", 49630423, ListaVuelos[3].Destino, ListaVuelos[3].Costo, false, ListaVuelos[3].EsInternacional, ListaVuelos[3].AvionVuelo.MatriculaAvion, true, 1);
            Pasaje Pasaje4 = new("Montaner", 41105244, ListaVuelos[4].Destino, ListaVuelos[4].Costo, true, ListaVuelos[4].EsInternacional, ListaVuelos[4].AvionVuelo.MatriculaAvion, true, 1);
            Pasaje Pasaje5 = new("Familia", 41177224, ListaVuelos[5].Destino, ListaVuelos[5].Costo, false, ListaVuelos[5].EsInternacional, ListaVuelos[5].AvionVuelo.MatriculaAvion, true, 0);
            Pasaje Pasaje6 = new("Prodi", 41100624, ListaVuelos[6].Destino, ListaVuelos[6].Costo, true, ListaVuelos[6].EsInternacional, ListaVuelos[6].AvionVuelo.MatriculaAvion, true, 1);
            Pasaje Pasaje7 = new("Familia", 41177224, ListaVuelos[6].Destino, ListaVuelos[6].Costo, true, ListaVuelos[6].EsInternacional, ListaVuelos[6].AvionVuelo.MatriculaAvion, true, 2);
            Pasaje Pasaje8 = new("Prodi", 41100624, ListaVuelos[5].Destino, ListaVuelos[5].Costo, false, ListaVuelos[5].EsInternacional, ListaVuelos[5].AvionVuelo.MatriculaAvion, true, 2);
            Pasaje Pasaje9 = new("Gerardo", 41152245, ListaVuelos[1].Destino, ListaVuelos[1].Costo, true, ListaVuelos[1].EsInternacional, ListaVuelos[1].AvionVuelo.MatriculaAvion, true, 1);

            ListaPasajes.Add(Pasaje1);ListaPasajes.Add(Pasaje2);ListaPasajes.Add(Pasaje3);ListaPasajes.Add(Pasaje4);
            ListaPasajes.Add(Pasaje5);ListaPasajes.Add(Pasaje6);ListaPasajes.Add(Pasaje7);ListaPasajes.Add(Pasaje8);
            ListaPasajes.Add(Pasaje9);

            //dentro de cada avion tengo que agregar a los pasajes en su lista
            ListaVuelos[0].ListaPasajes.Add(Pasaje0);
            ListaVuelos[1].ListaPasajes.Add(Pasaje1);
            ListaVuelos[2].ListaPasajes.Add(Pasaje2);
            ListaVuelos[3].ListaPasajes.Add(Pasaje3);
            ListaVuelos[4].ListaPasajes.Add(Pasaje4);
            ListaVuelos[5].ListaPasajes.Add(Pasaje5);
            ListaVuelos[6].ListaPasajes.Add(Pasaje6);
            ListaVuelos[6].ListaPasajes.Add(Pasaje7);
            ListaVuelos[5].ListaPasajes.Add(Pasaje8);
            ListaVuelos[1].ListaPasajes.Add(Pasaje9);

            //aca tuve que agregar las horas de los aviones porque este valor se suma al cargarlo por pantalla
            TimeSpan resultado;
            for (int i = 0; i <= 6; i++)
            {
                ListaVuelos[i].AsientosOcupados = ListaVuelos[i].ListaPasajes.Count;
                resultado = ListaVuelos[i].HoraLlegada.Subtract(ListaVuelos[i].HoraPartida);
                ListaVuelos[i].AvionVuelo.HorasDeVuelo = resultado.Hours;
            }

        }



    }
}
