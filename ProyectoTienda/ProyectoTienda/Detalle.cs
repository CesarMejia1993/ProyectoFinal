using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTienda
{
    public class Detalle
    {
        string codigoDeVentaDeta;
        string codigoProductoDeta;
        string cantidaDeta;

        public string CodigoDeVentaDeta
        {
            get
            {
                return codigoDeVentaDeta;
            }

            set
            {
                codigoDeVentaDeta = value;
            }
        }

        public string CodigoProductoDeta
        {
            get
            {
                return codigoProductoDeta;
            }

            set
            {
                codigoProductoDeta = value;
            }
        }

        public string CantidaDeta
        {
            get
            {
                return cantidaDeta;
            }

            set
            {
                cantidaDeta = value;
            }
        }
    }
}