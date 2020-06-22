using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
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
            Lbl_Cod.Text = GridView1.SelectedRow.Cells[1].Text;
            var direccion = GridView1.SelectedRow.Cells[8].Text;
            Image1.ImageUrl = direccion;
            //Actualizar
            Txt_Precio.Text = GridView1.SelectedRow.Cells[6].Text;
            Txt_Existencia.Text = GridView1.SelectedRow.Cells[7].Text;
            //Editar
            Txt_Nombre.Text = GridView1.SelectedRow.Cells[2].Text;
            Txt_Marca.Text = GridView1.SelectedRow.Cells[3].Text;
            Txt_Descripcion.Text = GridView1.SelectedRow.Cells[4].Text;
        }

        void Actualizar(string codigo, int existencia, string precio_v)
        {
            for (int i = 0; i < Productos.Count; i++)
            {
                if (Productos[i].Codigo == codigo)
                {
                    int suma = 0;
                    suma = Productos[i].Existencia + existencia;
                    Productos[i].Existencia = suma;
                    Productos[i].Precio_Venta = precio_v;
                }
            }

            string fileName = Server.MapPath("~/Productos.txt");

            //Para que sobreescriba los datos existentes se usa CREATE
            FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);
            //Se recorre toda la lista de clientes, que incluye a los ya modificados y se vuelve a grabar al archivo
            for (int i = 0; i < Productos.Count; i++)
            {
                writer.WriteLine(Productos[i].Codigo);
                writer.WriteLine(Productos[i].Nombre);
                writer.WriteLine(Productos[i].Marca);
                writer.WriteLine(Productos[i].Descripcion);
                writer.WriteLine(Productos[i].Precio_compra);
                writer.WriteLine(Productos[i].Precio_Venta);
                writer.WriteLine(Productos[i].Existencia);
                writer.WriteLine(Productos[i].Foto);
            }

            //Cerrar el archivo
            writer.Close();
            GridView1.DataSource = Productos;
            GridView1.DataBind();
        }

        protected void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            string cod = Lbl_Cod.Text;
            int exis = Convert.ToInt16(Txt_Existencia.Text);
            Actualizar(cod, exis, Txt_Precio.Text);
        }

        void Editar(string codigo, string nombre, string marca, string desc)
        {
            for (int i = 0; i < Productos.Count; i++)
            {
                if (Productos[i].Codigo == codigo)
                {
                    Productos[i].Nombre = nombre;
                    Productos[i].Marca = marca;
                    Productos[i].Descripcion = desc;
                }
            }

            string fileName = Server.MapPath("~/Productos.txt");

            //Para que sobreescriba los datos existentes se usa CREATE
            FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);
            //Se recorre toda la lista de clientes, que incluye a los ya modificados y se vuelve a grabar al archivo
            for (int i = 0; i < Productos.Count; i++)
            {
                writer.WriteLine(Productos[i].Codigo);
                writer.WriteLine(Productos[i].Nombre);
                writer.WriteLine(Productos[i].Marca);
                writer.WriteLine(Productos[i].Descripcion);
                writer.WriteLine(Productos[i].Precio_compra);
                writer.WriteLine(Productos[i].Precio_Venta);
                writer.WriteLine(Productos[i].Existencia);
                writer.WriteLine(Productos[i].Foto);
            }

            //Cerrar el archivo
            writer.Close();
            GridView1.DataSource = Productos;
            GridView1.DataBind();
        }

        protected void Btn_Editar_Click(object sender, EventArgs e)
        {
            string cod = Lbl_Cod.Text;

            Editar(cod, Txt_Nombre.Text, Txt_Marca.Text, Txt_Descripcion.Text);
        }
    }
}