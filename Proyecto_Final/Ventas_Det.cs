using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class Ventas_Det
    {
        int codigo;
        int codigo_venta;
        int codigo_prod;
        string nombre_p;
        string marca_p;
        string descr;
        int cant_prod;
        int precio;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Codigo_venta { get => codigo_venta; set => codigo_venta = value; }
        public int Codigo_prod { get => codigo_prod; set => codigo_prod = value; }
        public string Nombre_p { get => nombre_p; set => nombre_p = value; }
        public string Marca_p { get => marca_p; set => marca_p = value; }
        public string Descr { get => descr; set => descr = value; }
        public int Cant_prod { get => cant_prod; set => cant_prod = value; }
        public int Precio { get => precio; set => precio = value; }



    }
}