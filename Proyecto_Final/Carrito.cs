using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class Carrito
    {
        int codigo;
        int codigo_p;
        string nombre;
        string marca;
        string descripcion;
        string cantidad;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public int Codigo_p
        {
            get
            {
                return codigo_p;
            }

            set
            {
                codigo_p = value;
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

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        //public int Codigo { get => codigo; set => codigo = value; }
        //public int Codigo_p { get => codigo_p; set => codigo_p = value; }
        //public string Nombre { get => nombre; set => nombre = value; }
        //public string Marca { get => marca; set => marca = value; }
        //public string Descripcion { get => descripcion; set => descripcion = value; }
        //public string Cantidad { get => cantidad; set => cantidad = value; }
    }
}