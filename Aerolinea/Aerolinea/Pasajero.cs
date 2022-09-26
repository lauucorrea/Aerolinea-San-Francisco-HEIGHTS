using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;
namespace Entidades
{
    public class Pasajero:Cliente
    {
        private int cantidadBolsosMano;
        private int cantidadValijasBodega;
        private static int dniPasajero;

        protected Pasajero(string nombre,string apellido,int dni,int edad, int cantidadBolsosMano, int cantidadValijasBodega) : base(nombre,apellido,dni,edad)
        {
            DniPasajero = dni;
            CantidadBolsosMano = cantidadBolsosMano;
            CantidadValijasBodega = cantidadValijasBodega;
        }

        public int DniPasajero
        {
           get => dniPasajero;
           private set => dniPasajero = value;
        }
        
        public int CantidadValijasBodega
        {
            get => cantidadValijasBodega;
            private set => dniPasajero = value;
        }

        public int CantidadBolsosMano
        {
            get => cantidadBolsosMano;
            private set => cantidadBolsosMano = value;
        }

    }
}

