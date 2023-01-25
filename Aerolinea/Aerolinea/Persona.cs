using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Validaciones;

namespace Entidades
{
    [XmlInclude(typeof(Vendedor))]
    [XmlInclude(typeof(Cliente))]
    [Serializable]
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private Ecategoria categoria;
        private string usuario;
        private string password;
        private string rol;

       
        public Persona()
        {

        }
        //[JsonConstructor]
        public Persona(string nombre, string apellido, int dni, int edad, string usuario,string password)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Edad = edad;
            GestionarCategoria();
            Usuario = usuario;
            Password = password;
        }
        public enum Ecategoria
        {
            Persona,
            //Vendedor
            Novato,
            Cadete,
            Confiable,
            Experto,
            //Cliente
            Nuevo,
            Primerizo,
            Regular,
            VIP
        }

        public Ecategoria Categoria
        {
            set => categoria = value;
            get => categoria;
        }
        public string Rol
        {
            get => rol;
            set => rol = value;
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                if (ValidadoraDeDatos.ValidarString(value.ToLower()))
                {
                    apellido = value;
                }

                else
                {
                    throw new Exception("Apellido incorrecto");
                }

            }
        }
        public string Password
        {
            set => password = value;
            get => password;
        }

        public string Usuario
        {
            set => usuario = value;
            get => usuario;
        }

        public int Edad
        {
            get => edad;
            set
            {
                int edadConvertida;
                if (int.TryParse(value.ToString(), out edadConvertida))
                {
                    edad = edadConvertida;
                }
                else
                {
                    throw new Exception("Edad incorrecta");
                }
            }
        }

        public int Dni
        {
            get => dni;
            set
            {
                if (ValidadoraDeDatos.VerificarDni(value))
                {
                    dni = value;
                }
                else
                {
                    throw new Exception("Dni incorrecto");
                }
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (ValidadoraDeDatos.ValidarString(value.ToLower()))
                {
                    nombre = value;
                }

                else
                {
                    throw new Exception("Nombre incorrecto");
                }

            }

        }
        public abstract bool AdministrarLogIn(string usuario, string password);

        public virtual void GestionarCategoria()
        {
            Categoria = Ecategoria.Persona;
        }

        public string NombreApellido()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Nombre}-{Apellido}");

            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Nombre}-{Apellido}-{Dni}-{Edad}");

            return sb.ToString();
        }

        

    }
}
