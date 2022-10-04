using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Administracion
    {
        /// <summary>
        /// si las credenciales del vendedor existen, se loguea
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
            if (clienteRecibido is not null)
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
            else
            {
                throw new Exception("El cliente recibido no existe o es nulo");
            }
        }

        public static bool CheckearSiAvionExiste(Avion avionRecibido)
        {
            if (avionRecibido is not null)
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
            else
            {
                throw new ArgumentNullException("El avion recibido era nulo o no exite");
            }

        }

        public static bool CheckearSiVueloExiste(Vuelo vueloRecibido)
        {
            if (vueloRecibido is not null)
            {
                foreach (Vuelo vuelo in Registro.Vuelos)
                {
                    if (vuelo.GetHashCode() == vueloRecibido.GetHashCode())
                    {
                        return true;
                    }
                }
                throw new Exception("No encontramos el vuelo que buscabas");
            }
            else
            {
                throw new ArgumentNullException("El vuelo recibido era nulo o no existe");
            }


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

        public static bool AgregarVueloALista(Avion avionElegido, string origen, int indice, int horaPartida, int minutosPartida)
        {
            DateTime horaDespegue;
            DateTime horaLlegada;

            float costoVuelo;
            int horasDeVuelo;
            bool esInternacional;

            if (CheckearSiAvionExiste(avionElegido))
            {
                esInternacional = EsInternacional(indice);
                horasDeVuelo = CalcularCantidadDeHorasDeVuelo(esInternacional);
                costoVuelo = CalcularCostoDelVuelo(esInternacional, horasDeVuelo);

                horaDespegue = new DateTime(2022, 10, 01, horaPartida, minutosPartida, 0);
                horaLlegada = horaDespegue.AddHours(horasDeVuelo);

                Vuelo vueloCreado = new Vuelo(avionElegido, origen, horaDespegue, horaLlegada, (Destinos)indice, esInternacional, costoVuelo);
                if (vueloCreado is not null)
                {
                    Registro.Vuelos.Add(vueloCreado);
                    avionElegido.HorasDeVuelo += horasDeVuelo;
                    return true;
                }
                else
                {
                    throw new Exception("El programa fallo al crear un vuelo");
                }
            }
            throw new Exception("El avion seleccionado ya no existe");

        }

        public static bool AgregarPasajeALista(Vuelo vueloSeleccionado, string nombrePasajero, int cantidadValijas, int dniPasajero, int indice, float valorPasaje, bool esPremium, bool esInternacional, bool traeBolsos)
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
        public static bool AgregarAvionALista(bool ofreceComida, int cantidadAsientos, decimal capacidadBodega, int cantidadToilets, string matriculaAvion)
        {
            {
                Avion avion = new(ofreceComida, cantidadToilets, capacidadBodega, cantidadAsientos, matriculaAvion);
                if (!CheckearSiAvionExiste(avion))
                {
                    if (avion is not null)
                    {
                        Registro.Aviones.Add(avion);
                        return true;
                    }
                    else
                    {
                        throw new NullReferenceException("El programa fallo al crear un avion");
                    }
                }
                throw new Exception("Ya existe un avion con esta matricla");
            }

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
        private static bool EsInternacional(int indice)
        {
            bool ret = false;
            if (indice >= 0 && indice <= 14)
            {
                ret = false;
            }
            else if (indice > 14)
            {
                ret = true;
            }
            return ret;
        }

        /// <summary>
        /// dniYaEncontrados es una lista de documentos de los clientes ya encontrados
        /// solo suma 1 al contador de cada clase si se encontro un cliente nuevo
        /// </summary>
        /// <returns></returns>
        public static string CalcularRecaudacion()
        {
            int contadorPremium = 0;
            int contadorTurista = 0;
            float recaudacionPremium = 0;
            float recaudacionTurista = 0;
            float recaudacionTotal = 0;
            StringBuilder sb = new StringBuilder();
            List<int> dniYaEncontrados = new List<int>();
            if (Registro.Pasajes.Count > 0)
            {

                foreach (Pasaje pasaje in Registro.Pasajes)
                {
                    if (pasaje is not null)
                    {
                        if (!dniYaEncontrados.Contains(pasaje.DniPasajero))
                        {
                            dniYaEncontrados.Add(pasaje.DniPasajero);

                            if (pasaje.EsPremium)
                            {
                                recaudacionPremium += pasaje.ValorPasaje;
                                contadorPremium++;
                            }
                            else
                            {
                                recaudacionTurista += pasaje.ValorPasaje;
                                contadorTurista++;
                            }
                            recaudacionTotal += pasaje.ValorPasaje;
                        }
                    }
                }
                sb.AppendLine("Total de pasajeros en la aerolinea: " + dniYaEncontrados.Count);
                sb.AppendLine("Total de pasajes premium vendidos: " + contadorPremium);
                sb.AppendLine("Total de pasajes turista vendidos: " + contadorTurista);
                sb.AppendLine("Total recaudado premium: " + recaudacionPremium);
                sb.AppendLine("Total recaudado Turista: " + recaudacionTurista);
                sb.AppendLine("---------------------------------------");
                sb.AppendLine("Ganancia total: " + recaudacionTotal);

                return sb.ToString();
            }
            else
            {
                throw new Exception("No existen pasajeros cargados en la lista");
            }

        }

        /// <summary>
        /// segun el vuelo encontrado, se muestran los pasajeros que estan dentro de el
        /// </summary>
        /// <returns></returns>
        public static string ObtenerPasajerosPorVuelo()
        {
            if (Registro.Vuelos.Count > 0)
            {

                StringBuilder sb = new StringBuilder();
                foreach (Vuelo vuelo in Registro.Vuelos)
                {
                    sb.AppendLine($"Vuelo:\n{vuelo}");
                    sb.AppendLine("-------------------------------------------------");
                    if (vuelo is not null)
                    {
                        sb.AppendLine($"Cantidad de pasasajeros en este vuelo: {vuelo.AsientosOcupados}\n");
                        foreach (Pasaje pasaje in vuelo.ListaPasajes)
                        {
                            sb.AppendLine(pasaje.ToString());
                        }
                        sb.AppendLine("#################################################");
                    }
                }
                return sb.ToString();
            }
            else
            {
                throw new Exception("No hay vuelos cargados en la lista");
            }
        }

        /// <summary>
        /// Actualiza el diccionario de destinos con el valor de lo recaudado
        /// </summary>
        public static void ActualizarFacturacionesPorDestino()
        {
            if (Registro.Pasajes.Count > 0)
            {

                foreach (Destinos destino in Enum.GetValues(typeof(Destinos)))
                {
                    Registro.DiccionarioDestinos[destino] = 0;

                    foreach (Pasaje pasaje in Registro.Pasajes)
                    {
                        if (destino == pasaje.Destino)
                        {
                            Registro.DiccionarioDestinos[destino] += pasaje.ValorPasaje;
                        }

                    }
                }
            }
            else
            {
                throw new Exception("No hay pasajes cargados en la lista");
            }
        }

        public static string MostrarHorasDeVueloAeronave()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Avion avion in Registro.Aviones)
            {
                sb.AppendLine(avion.ToString());
            }

            return sb.ToString();
        }

    }
}
