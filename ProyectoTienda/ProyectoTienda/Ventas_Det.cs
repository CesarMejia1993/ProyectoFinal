using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTienda
{
    public class Ventas_Det
    {
        int codigo;
        int codigo_venta;
        int codigo_prod;
        int cant_prod;

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

        public int Codigo_venta
        {
            get
            {
                return codigo_venta;
            }

            set
            {
                codigo_venta = value;
            }
        }

        public int Codigo_prod
        {
            get
            {
                return codigo_prod;
            }

            set
            {
                codigo_prod = value;
            }
        }

        public int Cant_prod
        {
            get
            {
                return cant_prod;
            }

            set
            {
                cant_prod = value;
            }
        }
    }
}