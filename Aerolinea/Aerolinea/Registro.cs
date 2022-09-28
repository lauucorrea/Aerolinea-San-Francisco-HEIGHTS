using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private static DateTime tiempo = DateTime.Now;
        static Registro()
        {
            ListaPersonas = new List<Persona>();
            ListaPasajes = new List<Pasaje>();
            ListaAviones = new List<Avion>();
            ListaVuelos = new List<Vuelo>();
            HardcodeListas();
        }

        public static List <Pasaje> Pasajes
        {
            get => ListaPasajes;
        }

        public static List<Persona> Personas
        {
            get => ListaPersonas;
        }

        public static List<Avion> Aviones
        {
            get => ListaAviones;
        }

        public static List<Vuelo> Vuelos
        {
            get => ListaVuelos;
        }
        public static void HardcodeListas()
        {
            ListaPersonas.Add(new Vendedor("Lautaro", "Correa", 41080577, 24, "lau123", "asd123"));
            ListaPersonas.Add(new Vendedor("silvina", "peruca", 41100224, 50,"tedije","123"));
            ListaPersonas.Add(new Cliente("Familia", "Colombres", 41177224, 50));
            ListaPersonas.Add(new Cliente("Vencina", "Gentila", 49630423, 50));
            ListaPersonas.Add(new Cliente("Gerardo", "Pedila", 41152245, 50));
            ListaPersonas.Add(new Cliente("Prodi", "Sarapa", 41100624, 50));
            ListaPersonas.Add(new Cliente("Montaner", "Cecilia", 41105244, 50));

            ListaAviones.Add(new Avion(true, 2, 50, 22,  "a2e3df45gg5"));
            ListaAviones.Add(new Avion(true, 1, 40, 100, "u73we94fr23"));
            ListaAviones.Add(new Avion(false, 3, 110, 45,"o30rjf340f4"));
            ListaAviones.Add(new Avion(false, 2, 50, 12, "2ls9384l58t"));
            ListaAviones.Add(new Avion(true, 2, 80, 60,  "o03l285jfg6"));
            ListaAviones.Add(new Avion(false, 1, 40, 30, "we345fhi938"));
            ListaAviones.Add(new Avion(true, 1, 45, 22,  "qho3ol503f9"));

            ListaVuelos.Add(new Vuelo("BSAS", Destinos.SantaRosa.ToString(), Pasajes, 182000, "a2e3df45gg5"));
            ListaVuelos.Add(new Vuelo("BSAS", Destinos.Roma.ToString(), Pasajes, 182000, "we345fhi938"));
            ListaVuelos.Add(new Vuelo("BSAS", Destinos.PuertoMadryn.ToString(), Pasajes, 182000, "2ls9384l58t"));
            ListaVuelos.Add(new Vuelo("BSAS", Destinos.Neuquen.ToString(), Pasajes, 182000, "qho3ol503f9"));

        }
    }
}
