using System;
using Validaciones;
using System.Globalization;
namespace Entidades
{
    public class Administracion
    {
        public static bool AdministrarLogIn(string usuario, string password)
        {
            foreach (Vendedor vendedor in Registro.Personas)
            {
                if (vendedor.Password == password && vendedor.Usuario == usuario)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckearSiPersonaExiste(int dniPersona)
        {
            foreach (Persona persona in Registro.Personas)
            {
                if (persona.Dni == dniPersona)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckearSiAvionExiste(string matriculaAvion)
        {
            foreach (Avion avion in Registro.Aviones)
            {
                if (avion.MatriculaAvion == matriculaAvion)
                {
                    return true;
                }
            }
            return false;
        }

        public static Vendedor ObtenerVendedor(string usuario, string password)
        {
            foreach (Vendedor vendedor in Registro.Personas)
            {
                if (vendedor.Password == password && vendedor.Usuario == usuario)
                {
                    return vendedor;
                }
            }
            throw new Exception("El vendedor no existe");
        }

        public static Pasaje ObtenerVuelo(int idVuelo)
        {
            foreach (Pasaje vuelo in Registro.Pasajes)
            {
                if (vuelo.DniPasajero == idVuelo)
                {
                    return vuelo;
                }
            }
            throw new Exception("El vuelo no existe en nuestros registros");
        }


        public static Avion ObtenerAvion(string matriculaAvion)
        {
            foreach (Avion avion in Registro.Aviones)
            {
                if (avion.MatriculaAvion == matriculaAvion)
                {
                    return avion;
                }
            }
            throw new Exception("El avion no existe en nuestros registros");
        }

        public static bool AgregarClienteALista(string nombre, string apellido, string dni, string edad)
        {
            int dniPersona;
            int edadPersona;

            if (ValidadoraDeDatos.ConvertirDatosAerolinea(dni, edad, out dniPersona, out edadPersona))
            {
                if (!CheckearSiPersonaExiste(dniPersona))
                {
                    try
                    {
                        Persona PersonaCreada = new Cliente(nombre, apellido, dniPersona, edadPersona);
                        Registro.Personas.Add(PersonaCreada);
                        return true;
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
                else
                {
                    throw new Exception("Se encontro una persona con el mismo dni");
                }
            }

            return false;
        }

        public static bool AgregarVueloALista(string origen, int indice, bool esInternacional, int horaPartida, int minutosPartida, int duracionVuelo, float costo, string matriculaAvion)
        {
            float CostoDelVuelo;
            DateTime horaDespegue;
            DateTime horaLlegada;
            if (CheckearSiAvionExiste(matriculaAvion))
            {
                try
                {
                    CostoDelVuelo = CalcularCostoDelVuelo(esInternacional, horaPartida, duracionVuelo);
                    horaDespegue = new DateTime(2022, 10, 01, horaPartida, minutosPartida, 0);
                    horaLlegada = horaDespegue.AddHours(duracionVuelo);
                    Vuelo vueloCreado = new Vuelo(origen,horaDespegue,horaLlegada, (Destinos)indice, esInternacional, costo, matriculaAvion);
                    Registro.Vuelos.Add(vueloCreado);
                }
                catch
                {
                    throw new Exception("No se pudo crear un nuevo vuelo");
                }
                return true;
            }
            throw new Exception("El avion seleccionado ya no existe");

        }

        public static float CalcularCostoDelVuelo(bool esInternacional, int horaPartida, int duracionDeVuelo)
        {
            float costoNeto;

            if (esInternacional)
            {
                costoNeto = duracionDeVuelo * 100;
            }
            else
            {
                costoNeto = duracionDeVuelo * 50;
            }

            return costoNeto;
        }

        public static int CalcularCantidadDeHorasDeVuelo(bool esInternacional, int horaPartida)
        {
            Random random = new Random();
            int numeroRandom;
            if (esInternacional)
            {
                numeroRandom = random.Next(8, 12);
            }
            else
            {
                numeroRandom = random.Next(2, 4);
            }
            return numeroRandom;

        }




    }
}
