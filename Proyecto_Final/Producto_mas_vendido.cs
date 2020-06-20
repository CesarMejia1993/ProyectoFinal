using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class Producto_mas_vendido
    {
        int codigo;
        int codigo_pro;
        int cantidad_ventas;

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

        public int Codigo_pro
        {
            get
            {
                return codigo_pro;
            }

            set
            {
                codigo_pro = value;
            }
        }

        public int Cantidad_ventas
        {
            get
            {
                return cantidad_ventas;
            }

            set
            {
                cantidad_ventas = value;
            }
        }

        
    }
}