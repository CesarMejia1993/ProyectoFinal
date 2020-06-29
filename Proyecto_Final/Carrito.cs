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
        double precio;

        public int Codigo { get => codigo; set => codigo = value; }
        public int Codigo_p { get => codigo_p; set => codigo_p = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}