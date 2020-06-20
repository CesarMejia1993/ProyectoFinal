using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoTienda
{
    public partial class Producto_View : System.Web.UI.Page
    {

        static List<Producto> Productos = new List<Producto>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Productos.Clear();
                // Lista_P.Clear();
                //Lista_PTemp.Clear();
                //Leer el archivo con mediciones cada vez que se cargue o recargue la página
                //para que la lista de mediciones siempre tenga los datos correctos
                var archivo = Server.MapPath("~/Productos.txt");

                FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Producto emp = new Producto();
                    emp.Codigo = reader.ReadLine();
                    emp.Nombre = reader.ReadLine();
                    emp.Marca = reader.ReadLine();
                    emp.Descripcion = reader.ReadLine();
                    emp.Precio_compra = reader.ReadLine();
                    emp.Precio_Venta = reader.ReadLine();
                    emp.Existencia = Convert.ToInt16(reader.ReadLine());
                    emp.Foto = reader.ReadLine();
                    Productos.Add(emp);

                }
                reader.Close();

                GridView1.DataSource = Productos;
                GridView1.DataBind();
                //GridView1. = Image;
                //.Columns.RemoveAt(0);
                // TextBox1.Text = Convert.ToString(Total_sueldos);


            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var direccion = GridView1.SelectedRow.Cells[8].Text;
            Image1.ImageUrl = direccion;
        }
    }
}