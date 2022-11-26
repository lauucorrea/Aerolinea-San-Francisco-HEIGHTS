using System;

namespace Entidades
{
    public class Cliente : Persona
    {
        private bool tieneVuelosComprados;
        private int cantidadVuelosComprados;
        private string usuario;
        private string password;
        private Ecategoria categoria;
        public Cliente(string nombre, string apellido, int dni, int edad, string usuario, string password) : base(nombre, apellido, dni, edad)
        {
            TieneVuelosComprados = false;
            CantidadVuelosComprados = 0;
            Password = password;
            Usuario = usuario;

        }

        public enum Ecategoria
        {
            Nuevo,
            Primerizo,
            Regular,
            VIP
        }

        public Ecategoria Categoria
        {
            get => categoria;
            private set => categoria = value;
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
            if(CantidadVuelosComprados >= 1 && CantidadVuelosComprados < 2)
            {
                Categoria = Ecategoria.Primerizo;
            }
            else if(CantidadVuelosComprados >= 2 && CantidadVuelosComprados < 3)
            {
                Categoria = Ecategoria.Regular;
            }
            else if( CantidadVuelosComprados >= 3)
            {
                Categoria = Ecategoria.VIP;
            }
            else
            {
                Categoria = Ecategoria.Nuevo;
            }
        }
    }


}
