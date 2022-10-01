using System;
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
            throw new Exception("No encontramos un vendedor con estas credenciales");
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
        public static bool CheckearSiClienteExiste(Cliente clienteRecibido)
        {
            foreach (Persona persona in Registro.Personas)
            {
                if (persona is Cliente)
                {
                    if (((Cliente)persona).Equals(clienteRecibido))
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public static bool CheckearSiAvionExiste(Avion avionRecibido)
        {
            foreach (Avion avion in Registro.Aviones)
            {
                if (avion.Equals(avionRecibido))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckearSiVueloExiste(Vuelo vueloRecibido)
        {
            foreach (Vuelo vuelo in Registro.Vuelos)
            {
                if (vuelo.GetHashCode() == vueloRecibido.GetHashCode())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckearSiPasajeExiste(int dniPasajero, Vuelo vueloSeleccionado)
        {
            if (vueloSeleccionado is not null)
            {
                if (vueloSeleccionado.ListaPasajes.Count > 0)
                {
                    foreach (Pasaje pasaje in vueloSeleccionado.ListaPasajes)
                    {
                        if (pasaje.DniPasajero == dniPasajero)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            throw new Exception("No ha elegido ningun vuelo de la lista");
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

        public static bool AgregarClienteALista(string nombre, string apellido, int dni, int edad)
        {
            Cliente ClienteCreado = new Cliente(nombre, apellido, dni, edad);

            if (!CheckearSiClienteExiste(ClienteCreado))
            {
                if (ClienteCreado is not null)
                {
                    Registro.Personas.Add(ClienteCreado);
                    return true;
                }
                else
                {
                    throw new Exception("El programa fallo al crear un cliente");
                }


            }
            else
            {
                throw new Exception("Se encontro una persona con el mismo dni");
            }

        }

        public static bool AgregarVueloALista(Avion avionElegido, string origen, int indice, bool esInternacional, int horaPartida, int minutosPartida, int duracionVuelo, float costo)
        {
            DateTime horaDespegue;
            DateTime horaLlegada;
            if (CheckearSiAvionExiste(avionElegido))
            {
                horaDespegue = new DateTime(2022, 10, 01, horaPartida, minutosPartida, 0);
                horaLlegada = horaDespegue.AddHours(duracionVuelo);

                Vuelo vueloCreado = new Vuelo(avionElegido, origen, horaDespegue, horaLlegada, (Destinos)indice, esInternacional, costo);
                if (vueloCreado is not null)
                {
                    Registro.Vuelos.Add(vueloCreado);
                    return true;
                }
                else
                {
                    throw new Exception("El programa fallo al crear un vuelo");
                }
            }
            throw new Exception("El avion seleccionado ya no existe");

        }

        public static bool AgregarPasajeALista(Vuelo vueloSeleccionado, string nombrePasajero, int cantidadValijas, int dniPasajero, int indice, decimal valorPasaje, bool esPremium, bool esInternacional, bool traeBolsos)
        {
            if (vueloSeleccionado is not null)
            {
                if (!CheckearSiPasajeExiste(dniPasajero, vueloSeleccionado))
                {
                    Pasaje pasajeCreado = new Pasaje(nombrePasajero, dniPasajero, (Destinos)indice, valorPasaje, esPremium, esInternacional, vueloSeleccionado.AvionVuelo.MatriculaAvion, traeBolsos, cantidadValijas);
                    if (pasajeCreado is not null)
                    {
                        vueloSeleccionado.ListaPasajes.Add(pasajeCreado);
                        Registro.Pasajes.Add(pasajeCreado);

                        return true;
                    }
                    else
                    {
                        throw new NullReferenceException("El programa fallo al crear un pasaje");
                    }
                }
                throw new Exception("Ya existe un pasaje para esta persona en este vuelo");
            }
            throw new ArgumentNullException("No se ha seleccionado ningun avion");

        }

        public static float CalcularCostoDelVuelo(bool esInternacional, int duracionDeVuelo)
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

            return (float)Math.Round((double)costoNeto, 2);
        }

        public static int CalcularCantidadDeHorasDeVuelo(bool esInternacional)
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

       

        public static bool AvionPuedeCargarValijas(Avion avion,decimal pesoValijas)
        {
            decimal proximoPeso = avion.CargaActualBodega + pesoValijas;
            if (avion is not null)
            {
                if (proximoPeso <= avion.CapacidadBodega)
                {
                    return true;
                }
                throw new Exception("La cantidad de peso a cargar Excede los limites del avion");
            }
            throw new Exception("El avion seleccionado es nulo");
        }






    }
}
