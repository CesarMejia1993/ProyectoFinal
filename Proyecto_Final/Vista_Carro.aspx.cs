using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
{
    public partial class Vista_Carro : System.Web.UI.Page
    {
        static List<Cliente> Clientes = new List<Cliente>();
        static List<Ventas> Ventas = new List<Ventas>();

        int Cod_venta = 0;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Clientes.Clear();
                Cargar_Clientes();
                Ventas.Clear();
                Cargar_Ventas();
                GridView1.DataSource = Carro_Pub.Carro_Publico;
                GridView1.DataBind();
                Txt_Total.Text = Convert.ToString(suma());
                Txt_Fecha.Text = DateTime.Now.ToShortDateString();
                // ban = false;

            }

        }

        void Cargar_Clientes()
        {
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

                Clientes.Add(emp);

            }
            reader.Close();


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

        void Guardar_venta(string cod, string nit, string nombre, DateTime fecha, double total, string Tipo_pago, string estado)
        {
            var archivo = Server.MapPath("~/Ventas.txt");

            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(cod);
            writer.WriteLine(nit);
            writer.WriteLine(nombre);
            writer.WriteLine(fecha);
            writer.WriteLine(total);
            writer.WriteLine(Tipo_pago);
            writer.WriteLine(estado);
            writer.Close();
            stream.Close();
        }

        void Guardar_venta_detalle(int codigo, int codigo_venta, int codigo_prod, string nombre_p, string marca_p, string descr,
        int cant_prod, int precio)
        {
            var archivo = Server.MapPath("~/VentasDet.txt");

            FileStream stream = new FileStream(archivo, FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(codigo);
            writer.WriteLine(codigo_venta);
            writer.WriteLine(codigo_prod);
            writer.WriteLine(nombre_p);
            writer.WriteLine(marca_p);
            writer.WriteLine(descr);
            writer.WriteLine(cant_prod);
            writer.WriteLine(precio);
            writer.Close();
            stream.Close();
        }

        protected void Bnt_Comprar_Click(object sender, EventArgs e)
        {
            string ventacod = Convert.ToString(Ventas.Count() + 1);
            string date = Txt_Fecha.Text;
            string tipo_pago = DropDownList1.SelectedValue;
            bool ban = false;
            for (int i = 0; i < Clientes.Count; i++)
            {
                if (Clientes[i].Nit == Txt_Nit.Text)
                {
                    ban = false;
                }
                else { ban = true; }
            }

            if (ban == true)
            {
                Guardar_Cliente(Txt_Nit.Text, Txt_Nombre.Text, Txt_Apellido.Text, Txt_Direccion.Text, Txt_Telefono.Text);
            }

            Guardar_venta(ventacod, Txt_Nit.Text, Txt_Nombre.Text, Convert.ToDateTime(date), Convert.ToDouble(Txt_Total.Text), tipo_pago, "Pendiente");
            for (int i = 0; i < Carro_Pub.Carro_Publico.Count; i++)
            {
                Carro_Pub.Carro_Publico[i].Codigo_V = Convert.ToInt16(ventacod);
                Guardar_venta_detalle(Carro_Pub.Carro_Publico[i].Codigo, Carro_Pub.Carro_Publico[i].Codigo_V, Carro_Pub.Carro_Publico[i].Codigo_p,
                Carro_Pub.Carro_Publico[i].Nombre, Carro_Pub.Carro_Publico[i].Marca, Carro_Pub.Carro_Publico[i].Descripcion, Carro_Pub.Carro_Publico[i].Cantidad,
                Convert.ToInt16(Carro_Pub.Carro_Publico[i].Precio));

            }

        }

        protected void Bnt_Ver_Click(object sender, EventArgs e)
        {
            string nitB = Txt_Nit.Text;


            for (int i = 0; i < Clientes.Count; i++)
            {
                if (Clientes[i].Nit == nitB)
                {
                    Txt_Nombre.Text = Clientes[i].Nombre;
                    Txt_Apellido.Text = Clientes[i].Apellido;
                    Txt_Direccion.Text = Clientes[i].Direccion;
                    Txt_Telefono.Text = Clientes[i].Telefono;
                    //Txt_Total.Text = "00.00";
                    Txt_Nombre.Enabled = false;
                    Txt_Apellido.Enabled = false;
                    Txt_Direccion.Enabled = false;
                    Txt_Fecha.Enabled = false;
                    Txt_Telefono.Enabled = false;
                    Txt_Total.Enabled = false;


                }
                else
                {
                }
            }


        }

        int suma()
        {
            int tot = 0;
            for (int i = 0; i < Carro_Pub.Carro_Publico.Count; i++)
            {
                tot = tot + Convert.ToInt16(Carro_Pub.Carro_Publico[i].Precio * Carro_Pub.Carro_Publico[i].Cantidad);
            }
            return tot;
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
            stream.Close();
        }
    }
}