using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        protected Persona(string nombre, string apellido, int dni,int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Edad = edad;
        }
        public string Apellido
        {
            get => apellido;
            private set
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

        public int Edad
        {
            get => edad;
            private set
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
            private set
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
            private set
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Nombre}-{Apellido}-{Dni}-{Edad}");

            return sb.ToString();
        }

        

    }
}
