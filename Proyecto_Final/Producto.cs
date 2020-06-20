using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class Producto
    {
        string codigo;
        string nombre;
        string marca;
        string descripcion;
        string precio_compra;
        string precio_Venta;
        int existencia;
        string foto;

        public string Codigo
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

        public string Precio_compra
        {
            get
            {
                return precio_compra;
            }

            set
            {
                precio_compra = value;
            }
        }

        public string Precio_Venta
        {
            get
            {
                return precio_Venta;
            }

            set
            {
                precio_Venta = value;
            }
        }

        public int Existencia
        {
            get
            {
                return existencia;
            }

            set
            {
                existencia = value;
            }
        }

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }
    }
}