using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTienda
{
    public class Producto
    {
        string codigoProd;
        string nombreProd;
        string marcaProd;
        string descripcionProd;
        // imagen
        float precioCompraProd;
        float precioVentaProd;
        int cantidadProd;

        public string CodigoProd
        {
            get
            {
                return codigoProd;
            }

            set
            {
                codigoProd = value;
            }
        }

        public string NombreProd
        {
            get
            {
                return nombreProd;
            }

            set
            {
                nombreProd = value;
            }
        }

        public string MarcaProd
        {
            get
            {
                return marcaProd;
            }

            set
            {
                marcaProd = value;
            }
        }

        public string DescripcionProd
        {
            get
            {
                return descripcionProd;
            }

            set
            {
                descripcionProd = value;
            }
        }

        public float PrecioCompraProd
        {
            get
            {
                return precioCompraProd;
            }

            set
            {
                precioCompraProd = value;
            }
        }

        public float PrecioVentaProd
        {
            get
            {
                return precioVentaProd;
            }

            set
            {
                precioVentaProd = value;
            }
        }

        public int CantidadProd
        {
            get
            {
                return cantidadProd;
            }

            set
            {
                cantidadProd = value;
            }
        }
    }
}