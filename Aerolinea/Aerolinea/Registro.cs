using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum DestinosNacionales
    {
        SantaRosa, Bariloche, Corrientes, Cordoba, Jujuy, Mendoza, Neuquen, Posadas, Iguazu, Salta, SantiagoDelEstero, Trelew, Tucuman, PuertoMadryn, Ushuaia
    }

    public enum DestinosInternacionales
    {
        Recife, Roma, Acapulco, Miami
    }
    public static class Registro
    {
        private static List<Persona> ListaPersonas;
        private static List<Pasaje> ListaPasajes;
        public static List<Avion> ListaAviones;
        public static List<Vendedor> ListaVendedores;

        static Registro()
        {
            ListaVendedores = new List<Vendedor>();
            ListaPersonas = new List<Persona>();
            ListaPasajes = new List<Pasaje>();
            ListaAviones = new List<Avion>();
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
        public static void HardcodeListas()
        {
            ListaPersonas.Add(new Vendedor("Lautaro", "Correa", 41080577, 24, "lau123", "asd123"));
            ListaPersonas.Add(new Vendedor("silvina", "peruca", 41100224, 50,"tedije","123"));
            ListaPersonas.Add(new Cliente("Familia", "Colombres", 41177224, 50));
            ListaPersonas.Add(new Cliente("Vencina", "Gentila", 49630423, 50));
            ListaPersonas.Add(new Cliente("Gerardo", "Pedila", 41152245, 50));
            ListaPersonas.Add(new Cliente("Prodi", "Sarapa", 41100624, 50));
            
            ListaPersonas.Add(new Cliente("Montaner", "Cecilia", 41105244, 50));

        }
    }
}
