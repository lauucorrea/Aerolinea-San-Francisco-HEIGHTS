using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor:Persona
    {
        private string usuario;
        private string password;

        public Vendedor(string nombre, string apellido,int dni, int edad, string usuario, string contraseña) : base(nombre, apellido, dni, edad)
        {
            Usuario = usuario;
            Password = contraseña;
        }

        public string NombreApellido()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Nombre}-{Apellido}");

            return sb.ToString();
        }

        public string Password{
            private set => password = value;
            get => password;
        }

        public string Usuario
        {
            private set => usuario = value;
            get => usuario;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"VENDEDOR {Usuario}-{Nombre}-{Apellido}-{Dni}-{Edad}");

            return sb.ToString();
        }
    }
}
