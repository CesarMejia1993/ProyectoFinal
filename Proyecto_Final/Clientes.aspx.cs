using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
{
    public partial class Clientes : System.Web.UI.Page
    {
        static List<Cliente> clientes = new List<Cliente>();
        int codigo_count;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar_Cliente(Txt_Nit.Text, Txt_Nombre.Text, Txt_Apellido.Text, Txt_Direccion.Text, Txt_Telefono.Text);
        }

        void Guardar_Cliente(string nit, string nombre, string apellido, string direccion, string telefono)
        {
            var archivo = Server.MapPath("~/Clientes.txt");

            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(nit);
            writer.WriteLine(nombre);
            writer.WriteLine(apellido);
            writer.WriteLine(direccion);
            writer.WriteLine(telefono);
            writer.Close();


        }
        void Leer_CL()
        {

            clientes.Clear();
            // Lista_P.Clear();
            //Lista_PTemp.Clear();
            //Leer el archivo con mediciones cada vez que se cargue o recargue la página
            //para que la lista de mediciones siempre tenga los datos correctos
            var archivo = Server.MapPath("~/Clientes.txt");

            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Cliente emp = new Cliente();
                emp.Nit = reader.ReadLine();
                emp.Nombre = reader.ReadLine();
                emp.Apellido = reader.ReadLine();
                emp.Direccion = reader.ReadLine();
                emp.Telefono = reader.ReadLine();
                clientes.Add(emp);

            }
            reader.Close();

        }
    }
}