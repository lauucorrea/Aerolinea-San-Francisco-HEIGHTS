using System;
using System.Text;

namespace Entidades
{
    public class Vendedor : Persona
    {
        private string usuario;
        private string password;
        private int cantidadVuelosVendidos;
        private Ecategoria categoria;
        public Vendedor(string nombre, string apellido, int dni, int edad, string usuario, string contraseña, int cantidad) : base(nombre, apellido, dni, edad)
        {
            Usuario = usuario;
            Password = contraseña;
            cantidadVuelosVendidos = 0;
            cantidadVuelosVendidos = cantidad;
        }


        public string Password
        {
            private set => password = value;
            get => password;
        }

        public string Usuario
        {
            private set => usuario = value;
            get => usuario;
        }

        public int CantidadVuelosVendidos
        {
            set => cantidadVuelosVendidos = value;
            get => cantidadVuelosVendidos;
        }
        public enum Ecategoria
        {
            Novato,
            Cadete,
            Confiable,
            Experto
        }

        public Ecategoria Categoria
        {
            get => categoria;
            private set => categoria = value;
        }

        public override bool AdministrarLogIn(string usuario, string password)
        {
            if (Password == password && Usuario == usuario)
            {
                return true;
            }
            return false;
        }

        public void GestionarCategoria()
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
            StringBuilder sb = new StringBuilder();

            sb.Append($"VENDEDOR {Usuario}-{Nombre}-{Apellido}-{Dni}-{Edad}");

            return sb.ToString();
        }
    }
}
