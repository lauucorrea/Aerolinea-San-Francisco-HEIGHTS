using System;
using System.Collections.Generic;
using Validaciones;
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
            foreach (Avion avion in Registro.ListaAviones)
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


    }
}
