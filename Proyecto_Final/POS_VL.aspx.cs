using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
{
    public partial class POS_VL : System.Web.UI.Page
    {
        static List<Producto> Productos = new List<Producto>();
        public static List<Carrito> Carrito_Compra = new List<Carrito>();

        protected void Page_Load(object sender, EventArgs e)
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

        }

        protected void Bnt_Agregar_Click(object sender, EventArgs e)
        {

            bool ban = false;
            ban = true;
            int band2 = 0;
            int produ = 0;
            for (int i = 0; i < Carro_Pub.Carro_Publico.Count; i++)
            {

                if (Convert.ToInt16(Lbl_Cod.Text) == Carro_Pub.Carro_Publico[i].Codigo_p)
                {
                    band2 = 1;
                    produ = i;
                }
                else
                {

                }

            }
            if (band2 == 1)
            {
                Carro_Pub.Carro_Publico[produ].Cantidad = Carro_Pub.Carro_Publico[produ].Cantidad + 1;
                ban = false;
            }
            else//if (ban==true)
            {
                Carrito venta_carro = new Carrito();
                venta_carro.Codigo = Carro_Pub.Carro_Publico.Count + 1;
                venta_carro.Codigo_p = Convert.ToInt16(Lbl_Cod.Text);
                venta_carro.Nombre = Txt_Nombre.Text;
                venta_carro.Marca = Txt_Marca.Text;
                venta_carro.Descripcion = Txt_Descripcion.Text;
                //venta_carro.Cantidad = 1;
                venta_carro.Precio = Convert.ToDouble(Txt_Precio.Text);
                Carro_Pub.Carro_Publico.Add(venta_carro);
            }
            if (Carro_Pub.Carro_Publico.Count == 0)
            {
                Carrito venta_carro = new Carrito();
                venta_carro.Codigo = Carro_Pub.Carro_Publico.Count + 1;
                venta_carro.Codigo_p = Convert.ToInt16(Lbl_Cod.Text);
                venta_carro.Nombre = Txt_Nombre.Text;
                venta_carro.Marca = Txt_Marca.Text;
                venta_carro.Descripcion = Txt_Descripcion.Text;
               // venta_carro.Cantidad = 1;
                venta_carro.Precio = Convert.ToDouble(Txt_Precio.Text);
                Carro_Pub.Carro_Publico.Add(venta_carro);
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbl_Cod.Text = GridView1.SelectedRow.Cells[1].Text;
            var direccion = GridView1.SelectedRow.Cells[8].Text;
            Image1.ImageUrl = direccion;
            //Actualizar
            Txt_Precio.Text = GridView1.SelectedRow.Cells[6].Text;
            //Existencia.Text = GridView1.SelectedRow.Cells[7].Text;
            //Editar
            Txt_Nombre.Text = GridView1.SelectedRow.Cells[2].Text;
            Txt_Marca.Text = GridView1.SelectedRow.Cells[3].Text;
            Txt_Descripcion.Text = GridView1.SelectedRow.Cells[4].Text;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[5].Visible = false;
        }
    }
}