using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {
        private bool tieneVuelosComprados;

        public Cliente(string nombre, string apellido, int dni, int edad) : base(nombre, apellido, dni, edad)
        {
            TieneVuelosComprados = false;
        }
        #region setters
        public bool TieneVuelosComprados
        {
            get => tieneVuelosComprados;
            private set => tieneVuelosComprados = value;
        }
        public override int GetHashCode()
        {
            return Dni;
        }
        #endregion

        #region sobrecargas
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {Nombre} - Apellido: {Apellido} - Dni: {Dni} - Edad: {Edad} - Tiene vuelos comprados? : {tieneVuelosComprados}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;

            return cliente is not null && Dni == cliente.Dni;
        }

        #endregion

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
