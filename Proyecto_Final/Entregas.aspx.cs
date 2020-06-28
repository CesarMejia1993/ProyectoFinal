using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
{
    public partial class Entregas : System.Web.UI.Page
    {
        static List<Ventas> Ventas = new List<Ventas>();
        static List<Ventas> Ventas_E = new List<Ventas>();
        static List<Ventas> Ventas_P = new List<Ventas>();

        int Cod_venta = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Ventas.Clear();
                Cargar_Ventas();
                Ventas_P.Clear();
                Ventas_E.Clear();
                Actualizar();

            }
        }

        void Cargar_Ventas()
        {
            //Txt_Nombre.Text = "Hola";
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
                Cod_venta = venta.Codigo + 1;
            }

            reader.Close();
            stream.Close();
        }

        void Actualizar()
        {
            for (int i = 0; i < Ventas.Count; i++)
            {
                if (Ventas[i].Estado == "Pendiente")
                {
                    Ventas Venta_Pendiente = new Ventas();
                    Venta_Pendiente.Codigo = Ventas[i].Codigo;
                    Venta_Pendiente.Nit_cl = Ventas[i].Nit_cl;
                    Venta_Pendiente.Nombre = Ventas[i].Nombre;
                    Venta_Pendiente.Fecha = Ventas[i].Fecha;
                    Venta_Pendiente.Total = Ventas[i].Total;
                    Venta_Pendiente.Tipo_pago = Ventas[i].Tipo_pago;
                    Venta_Pendiente.Estado = Ventas[i].Estado;
                    Ventas_P.Add(Venta_Pendiente);
                }
                else
                {
                    Ventas Venta_Entregada = new Ventas();
                    Venta_Entregada.Codigo = Ventas[i].Codigo;
                    Venta_Entregada.Nit_cl = Ventas[i].Nit_cl;
                    Venta_Entregada.Nombre = Ventas[i].Nombre;
                    Venta_Entregada.Fecha = Ventas[i].Fecha;
                    Venta_Entregada.Total = Ventas[i].Total;
                    Venta_Entregada.Tipo_pago = Ventas[i].Tipo_pago;
                    Venta_Entregada.Estado = Ventas[i].Estado;
                    Ventas_E.Add(Venta_Entregada);
                }
            }

            GridView2.DataSource = Ventas_P;
            GridView2.DataBind();
            GridView1.DataSource = Ventas_E;
            GridView1.DataBind();
        }

        void Guardar_venta()
        {
            var archivo = Server.MapPath("~/Ventas.txt");

            FileStream stream = new FileStream(archivo, FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);
            for (int i = 0; i < Ventas.Count; i++)
            {
                writer.WriteLine(Ventas[i].Codigo);
                writer.WriteLine(Ventas[i].Nit_cl);
                writer.WriteLine(Ventas[i].Nombre);
                writer.WriteLine(Ventas[i].Fecha);
                writer.WriteLine(Ventas[i].Total);
                writer.WriteLine(Ventas[i].Tipo_pago);
                writer.WriteLine(Ventas[i].Estado);
            }
            writer.Close();
            stream.Close();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aqui va el Codigo de Pendientes
            Txt_Cod.Text = GridView2.SelectedRow.Cells[1].Text;
            Txt_Nombre.Text = GridView2.SelectedRow.Cells[3].Text;
        }

        protected void Btn_Entregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Ventas.Count; i++)
            {
                if (Ventas[i].Codigo == Convert.ToInt16(Txt_Cod.Text))
                {
                    Ventas[i].Estado = "Entregada";
                }
            }

            Guardar_venta();
            Ventas.Clear();
            Cargar_Ventas();
            Ventas_P.Clear();
            Ventas_E.Clear();
            Actualizar();
        }
    }
}