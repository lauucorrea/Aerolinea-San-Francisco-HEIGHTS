using System;

namespace Entidades
{
    public class Cliente : Persona
    {
        private bool tieneVuelosComprados;
        private int cantidadVuelosComprados;
       
        public Cliente()
        {

        }
        public Cliente(string nombre, string apellido, int dni, int edad, string usuario, string password) : base(nombre, apellido, dni, edad,usuario,password)
        {
            TieneVuelosComprados = false;
            CantidadVuelosComprados = 0;
            Rol = "Cliente";
        }


        public bool TieneVuelosComprados
        {
            get => tieneVuelosComprados;
            set => tieneVuelosComprados = value;
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
