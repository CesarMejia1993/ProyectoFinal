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
        string descripcion;
        int cantidad_ventas;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Codigo_pro { get => codigo_pro; set => codigo_pro = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad_ventas { get => cantidad_ventas; set => cantidad_ventas = value; }



    }
}