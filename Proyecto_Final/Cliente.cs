using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class Cliente
    {
        string nit;
        string nombre;
        string apellido;
        string direccion;
        string telefono;

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        //public string Nit { get => nit; set => nit = value; }
        //public string Nombre { get => nombre; set => nombre = value; }
        //public string Apellido { get => apellido; set => apellido = value; }
        //public string Direccion { get => direccion; set => direccion = value; }
        //public string Telefono { get => telefono; set => telefono = value; }
    }
}