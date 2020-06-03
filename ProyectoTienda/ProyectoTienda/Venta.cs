using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTienda
{
    public class Venta
    {
        string codigoVenta;
        string nitClienteVenta;
        DateTime fechaVenta;
        int totalVenta;
        byte estadoVenta;

        public string CodigoVenta
        {
            get
            {
                return codigoVenta;
            }

            set
            {
                codigoVenta = value;
            }
        }

        public string NitClienteVenta
        {
            get
            {
                return nitClienteVenta;
            }

            set
            {
                nitClienteVenta = value;
            }
        }

        public DateTime FechaVenta
        {
            get
            {
                return fechaVenta;
            }

            set
            {
                fechaVenta = value;
            }
        }

        public int TotalVenta
        {
            get
            {
                return totalVenta;
            }

            set
            {
                totalVenta = value;
            }
        }

        public byte EstadoVenta
        {
            get
            {
                return estadoVenta;
            }

            set
            {
                estadoVenta = value;
            }
        }
    }
}