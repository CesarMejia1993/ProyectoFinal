using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTienda
{
    public class Pendiente_entrega
    {

        int codigo;
        string nit_cl;
        int codigo_venta;
        string estado;

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

        public string Nit_cl
        {
            get
            {
                return nit_cl;
            }

            set
            {
                nit_cl = value;
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

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}