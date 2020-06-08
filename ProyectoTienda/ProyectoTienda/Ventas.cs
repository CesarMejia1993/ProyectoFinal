using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTienda
{
    public class Ventas
    {
        int codigo;
        string nit_cl;
        DateTime fecha;
        double total;
        string tipo_pago;
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

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string Tipo_pago
        {
            get
            {
                return tipo_pago;
            }

            set
            {
                tipo_pago = value;
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