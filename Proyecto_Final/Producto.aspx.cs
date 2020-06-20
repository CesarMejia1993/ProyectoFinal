using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
{
    public partial class Producto1 : System.Web.UI.Page
    {
        static List<Producto> Productos = new List<Producto>();
        int codigo1 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Btn_Guardar_Click(object sender, EventArgs e)
        {
            leer();
            string nombreArchivo = "";
            string ruta="";
            if (FileUpload1.HasFile)
            {
                //si hay una archivo.
                nombreArchivo = FileUpload1.FileName;
                ruta = "~/Fotos/" + nombreArchivo;
                FileUpload1.SaveAs(Server.MapPath(ruta));

                //Label1.Text = "Se guardó la imagen. y su ruta es" + Environment.NewLine + ruta;
            }

            string codigo = Convert.ToString(codigo1 + 1); ;
            string nombre = Txt_Nombre.Text;
            string marca = Txt_Marca.Text;
            string descrip = Txt_Descripcion.Text;
            string Precio = Txt_Compra.Text;
            string venta = Txt_Venta.Text;
            int cantidad = Convert.ToInt16(Txt_Existencia.Text);
            string imagen = ruta;
            Guardar_Producto(codigo,nombre,marca,descrip,Precio,venta,cantidad,imagen);

            Response.Redirect("Default.aspx");
        }


        void Guardar_Producto(string codigo,string nombre, string marca, string descripcion, string precio_compra,string Precio_venta, int existencia , string imagen )
        {
            var archivo = Server.MapPath("~/Productos.txt");

            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(codigo);
            writer.WriteLine(nombre);
            writer.WriteLine(marca);
            writer.WriteLine(descripcion);
            writer.WriteLine(precio_compra);
            writer.WriteLine(Precio_venta);
            writer.WriteLine(existencia);
            writer.WriteLine(imagen);
            writer.Close();

            
        }
        
        void leer()
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
                codigo1 = codigo1 + 1;
            }
            reader.Close();


            //GridView1. = Image;
            //.Columns.RemoveAt(0);
            // TextBox1.Text = Convert.ToString(Total_sueldos);
        }
    }
}