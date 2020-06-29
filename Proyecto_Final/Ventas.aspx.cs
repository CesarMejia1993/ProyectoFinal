using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
{
    public partial class Ventas1 : System.Web.UI.Page
    {
        static List<Cliente> Clientes = new List<Cliente>();
        static List<Producto> Productos = new List<Producto>();
        static List<Ventas> Ventas = new List<Ventas>();
        static List<Ventas_Det> detalle = new List<Ventas_Det>();

        int Cod_venta = 0;
        string cod_cl;
        string cod_Pd;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Clientes.Clear();
                Cargar_Clientes();
                Productos.Clear();
                Cargar_Productos();
                Ventas.Clear();
                Cargar_Ventas();
                Txt_Estado.Text = "Pendiente";
                Txt_Fecha.Text = DateTime.Now.ToShortDateString();
                Lbl_Cod.Text = Convert.ToString(Cod_venta);
                Txt_Total.Text = "00";


            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cod_cl = DropDownList1.SelectedValue;
            for (int i = 0; i < Clientes.Count; i++)
            {
                if (Clientes[i].Nit == cod_cl)
                {
                    Txt_Nombre.Text = Clientes[i].Nombre;
                }
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

            DropDownList1.DataValueField = "Nit";
            DropDownList1.DataTextField = "Nombre";
            DropDownList1.DataSource = Clientes;
            DropDownList1.DataBind();
        }

        void Cargar_Productos()
        {
            //Txt_Nombre.Text = "Hola";
            var archivo = Server.MapPath("~/Productos.txt");
            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Producto producto = new Producto();
                producto.Codigo = reader.ReadLine();
                producto.Nombre = reader.ReadLine();
                producto.Marca = reader.ReadLine();
                producto.Descripcion = reader.ReadLine();
                producto.Precio_compra = reader.ReadLine();
                producto.Precio_Venta = reader.ReadLine();
                producto.Existencia = Convert.ToInt16(reader.ReadLine());
                producto.Foto = reader.ReadLine();

                Productos.Add(producto);
            }


            reader.Close();
            stream.Close();

            DropDownList2.DataValueField = "Codigo";
            DropDownList2.DataTextField = "Nombre";
            DropDownList2.DataSource = Productos;
            DropDownList2.DataBind();
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

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            //Txt_Nombre.Text = "Hola";
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cod_Pd = DropDownList2.SelectedValue;
            for (int i = 0; i < Productos.Count; i++)
            {
                if (Productos[i].Codigo == cod_Pd)
                {
                    Txt_Nombre_p.Text = Productos[i].Nombre;
                    Txt_Marca.Text = Productos[i].Marca;
                    Txt_Desc.Text = Productos[i].Descripcion;
                    Txt_Precio.Text = Productos[i].Precio_Venta;
                }
            }
        }

        protected void Bnt_Guardar_Click(object sender, EventArgs e)
        {
            string cod = Convert.ToString(Lbl_Cod.Text);
            DateTime fech = Convert.ToDateTime(Txt_Fecha.Text);
            double total1 = Convert.ToDouble(Txt_Total.Text);
            string T_pago = DropDownList3.SelectedValue;
            string nit1 = DropDownList1.SelectedValue;
            Guardar_venta(cod, nit1, Txt_Nombre.Text, fech, total1, T_pago, Txt_Estado.Text);

            for (int i = 0; i < detalle.Count; i++)
            {
                Guardar_venta_detalle(detalle[i].Codigo, detalle[i].Codigo_venta, detalle[i].Codigo_prod, detalle[i].Nombre_p, detalle[i].Marca_p,
                    detalle[i].Descr, detalle[i].Cant_prod, detalle[i].Precio);
            }

        }

        protected void Btn_Agregar_Click(object sender, EventArgs e)
        {
            int Total_vent = 0;
            int cod_det = detalle.Count + 1;
            int cod_vent = Convert.ToInt16(Lbl_Cod.Text);
            int cod_prod = Convert.ToInt16(DropDownList2.SelectedValue);
            string nombre_p = Txt_Nombre_p.Text;
            int cant_p = Convert.ToInt16(Txt_cant.Text);
            int precio1 = cant_p * Convert.ToInt16(Txt_Precio.Text);

            Agregar_detalle(cod_det, cod_vent, cod_prod, nombre_p, Txt_Marca.Text, Txt_Desc.Text, cant_p, precio1);
            for (int i = 0; i < detalle.Count; i++)
            {
                Total_vent = Total_vent + detalle[i].Precio;
                Txt_Total.Text = Convert.ToString(Total_vent);
            }
        }

        void Agregar_detalle(int codigo, int codigo_venta, int codigo_prod, string nombre_p, string marca_p, string descr,
        int cant_prod, int precio)
        {

            Ventas_Det det = new Ventas_Det();
            det.Codigo = codigo;
            det.Codigo_venta = codigo_venta;
            det.Codigo_prod = codigo_prod;
            det.Nombre_p = nombre_p;
            det.Marca_p = marca_p;
            det.Descr = descr;
            det.Cant_prod = cant_prod;
            det.Precio = precio;
            detalle.Add(det);

            GridView1.DataSource = detalle;
            GridView1.DataBind();
        }
    }
}