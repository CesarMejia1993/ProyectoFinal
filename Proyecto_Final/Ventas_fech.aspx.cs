using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
{
    public partial class Ventas_fech : System.Web.UI.Page
    {
        static List<Ventas> Ventas = new List<Ventas>();
        static List<Ventas> Vista = new List<Ventas>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Ventas.Clear();
                Cargar_Ventas();
            }
        }

        protected void Btn_Buscar_Click(object sender, EventArgs e)
        {
            //Buscar();
            int suma = 0;
            for (int i = 0; i < Ventas.Count; i++)
            {
                DateTime inicio = Calendar1.SelectedDate;
                DateTime fin = Calendar2.SelectedDate;
                if ((Ventas[i].Fecha >= inicio) && (Ventas[i].Fecha <= fin))
                {
                    Ventas ven = new Ventas();
                    ven.Codigo = Ventas[i].Codigo;
                    ven.Nit_cl = Ventas[i].Nit_cl;
                    ven.Nombre = Ventas[i].Nombre;
                    ven.Fecha = Ventas[i].Fecha;
                    ven.Total = Ventas[i].Total;
                    ven.Tipo_pago = Ventas[i].Tipo_pago;
                    ven.Estado = Ventas[i].Estado;
                    Vista.Add(ven);
                    suma = suma + Convert.ToInt16(Ventas[i].Total);
                }
            }
            GridView1.DataSource = Vista;
            GridView1.DataBind();
            Txt_Ganancias.Text = Convert.ToString(suma);
        }

        void Cargar_Ventas()
        {

            var archivo = Server.MapPath("~/Ventas.txt");
            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Ventas venta = new Ventas();
                venta.Codigo = Convert.ToInt16(reader.ReadLine());
                venta.Nit_cl = reader.ReadLine();
                venta.Nombre = reader.ReadLine();
                venta.Fecha = Convert.ToDateTime(reader.ReadLine());
                venta.Total = Convert.ToDouble(reader.ReadLine());
                venta.Tipo_pago = reader.ReadLine();
                venta.Estado = reader.ReadLine();
                Ventas.Add(venta);
            }

            reader.Close();
            stream.Close();
            GridView1.DataSource = Ventas;
            GridView1.DataBind();
        }




    }
}