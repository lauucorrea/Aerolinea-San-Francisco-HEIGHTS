using System;
using System.Text;

namespace Entidades
{
    public class Vendedor : Persona
    {
        private int cantidadVuelosVendidos;

        public Vendedor()
        {

        }
        public Vendedor(string nombre, string apellido, int dni, int edad, string usuario, string password) : base(nombre, apellido, dni, edad,usuario,password)
        {
            cantidadVuelosVendidos = 0;
            Rol = "Vendedor";
        }


        public int CantidadVuelosVendidos
        {
            set => cantidadVuelosVendidos = value;
            get => cantidadVuelosVendidos;
        }


        public override bool AdministrarLogIn(string usuario, string password)
        {
            if (Password == password && Usuario == usuario)
            {
                return true;
            }
            return false;
        }
        
        public override void GestionarCategoria()
        {
            if (CantidadVuelosVendidos >= 1 && CantidadVuelosVendidos < 2)
            {
                Categoria = Ecategoria.Cadete;
            }
            else if (CantidadVuelosVendidos >= 2 && CantidadVuelosVendidos < 3)
            {
                Categoria = Ecategoria.Confiable;
            }
            else if (CantidadVuelosVendidos >= 3)
            {
                Categoria = Ecategoria.Experto;
            }
            else
            {
                Categoria = Ecategoria.Novato;
            }
            
        }
        public override string ToString()
        {
            StringBuilder sb = new ();

            sb.Append($"VENDEDOR {Usuario}-{Nombre}-{Apellido}-{Dni}-{Edad}");

            return sb.ToString();
        }
    }
}
