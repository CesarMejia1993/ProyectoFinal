using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
{
    public partial class Clientes_View : System.Web.UI.Page
    {
        static List<Cliente> clientes = new List<Cliente>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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

                GridView1.DataSource = clientes;
                GridView1.DataBind();
                //GridView1. = Image;
                //.Columns.RemoveAt(0);
                // TextBox1.Text = Convert.ToString(Total_sueldos);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}