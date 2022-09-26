using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {
        private bool tieneVuelosComprados;

        public Cliente(string nombre,string apellido,int dni, int edad):base(nombre, apellido, dni, edad)
        {
            TieneVuelosComprados = false;
        }

        public bool TieneVuelosComprados
        {
            get => tieneVuelosComprados;
            private set => tieneVuelosComprados = value;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {Nombre} - Apellido: {Apellido} - Dni: {Dni} - Edad: {Edad} - Tiene vuelos comprados? : {tieneVuelosComprados}");

            return sb.ToString();
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
