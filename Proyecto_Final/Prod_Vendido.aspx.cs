using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
{
    public partial class Prod_Vendido : System.Web.UI.Page
    {
        static List<Ventas_Det> lista_Principal = new List<Ventas_Det>();
        static List<Producto_mas_vendido> Vista = new List<Producto_mas_vendido>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lista_Principal.Clear();
                Cargar_DEt();
                Vista.Clear();
                Buscar();


            }
        }

        void Cargar_DEt()
        {
            //Txt_Nombre.Text = "Hola";
            var archivo = Server.MapPath("~/VentasDet.txt");
            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Ventas_Det venta = new Ventas_Det();
                venta.Codigo = Convert.ToInt16(reader.ReadLine());
                venta.Codigo_venta = Convert.ToInt16(reader.ReadLine());
                venta.Codigo_prod = Convert.ToInt16(reader.ReadLine());
                venta.Nombre_p = reader.ReadLine();
                venta.Marca_p = reader.ReadLine();
                venta.Descr = reader.ReadLine();
                venta.Cant_prod = Convert.ToInt16(reader.ReadLine());
                venta.Precio = Convert.ToInt16(reader.ReadLine());

                lista_Principal.Add(venta);

            }

            reader.Close();
            stream.Close();

            GridView1.DataSource = lista_Principal;
            GridView1.DataBind();
        }

        void Buscar()
        {

            for (int i = 0; i < lista_Principal.Count; i++)
            {
                int cont = 0;
                bool encontrar = false;
                for (int j = 0; j < lista_Principal.Count; j++)
                {
                    if (lista_Principal[i].Codigo_prod == lista_Principal[j].Codigo_prod)
                    {
                        cont = cont + lista_Principal[j].Cant_prod;
                    }
                }

                for (int x = 0; x < Vista.Count; x++)
                {
                    if (lista_Principal[i].Codigo_prod == Vista[x].Codigo_pro)
                    {
                        encontrar = true;
                    }
                }
                if (encontrar == false)
                {
                    Producto_mas_vendido vent = new Producto_mas_vendido();
                    vent.Codigo = Vista.Count + 1;
                    vent.Codigo_pro = lista_Principal[i].Codigo_prod;
                    vent.Descripcion = lista_Principal[i].Descr;
                    vent.Cantidad_ventas = cont;
                    Vista.Add(vent);
                }
            }

            Vista = Vista.OrderByDescending(o => o.Cantidad_ventas).ToList();
            GridView1.DataSource = Vista;
            GridView1.DataBind();
        }
    }
}