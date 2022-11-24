using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {
        private bool tieneVuelosComprados;
        private int cantidadVuelosComprados;

        public Cliente(string nombre, string apellido, int dni, int edad) : base(nombre, apellido, dni, edad)
        {
            TieneVuelosComprados = false;
        }

        public bool TieneVuelosComprados
        {
            get => tieneVuelosComprados;
            private set => tieneVuelosComprados = value;
        }
        public int CantidadVuelosComprados
        {
            get => cantidadVuelosComprados;
            set => cantidadVuelosComprados = value;
        }
        public override int GetHashCode()
        {
            return Dni;
        }

        public bool ObtenerListaDePasajes(int dni, List<Pasaje> vuelosRealizados)
        {
            bool seEncontroVuelo = false;
            foreach (Pasaje pasaje in vuelosRealizados)
            {
                if (pasaje.DniPasajero == dni)
                {
                    vuelosRealizados.Add(pasaje);
                    seEncontroVuelo = true;
                }
            }
            if (seEncontroVuelo) { return seEncontroVuelo; }

            throw new Exception("No se pudo obtener la lista de pasajes");
        }
    }


}
