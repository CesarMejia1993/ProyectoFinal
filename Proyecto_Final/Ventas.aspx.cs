using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Final
{
    //public partial class Ventas1 : System.Web.UI.Page
    //{
    //    static List<Cliente> Clientes = new List<Cliente>();
    //    static List<Producto> Productos = new List<Producto>();
    //    string cod_cl;
    //    string cod_Pd;
    //    protected void Page_Load(object sender, EventArgs e)
    //    {
    //        if (!IsPostBack)
    //        {
    //            Clientes.Clear();
    //            Cargar_Clientes();
    //            Cargar_Productos();
    //            Txt_Estado.Text = "Pendiente";
    //            Txt_Fecha.Text = DateTime.Now.ToShortDateString();
    //        }
    //    }

    //    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    //    {
    //        Txt_Nombre.Text = "Cambio";
    //        cod_cl = DropDownList1.SelectedValue;
    //        for (int i = 0; i < Clientes.Count; i++)
    //        {
    //            if (Clientes[i].Nit == cod_cl)
    //            {
    //                Txt_Nombre.Text = Clientes[i].Nombre;
    //            }
    //        }
    //    }

    //    void Cargar_Clientes()
    //    {
    //        //Txt_Nombre.Text = "Hola";
    //        var archivo = Server.MapPath("~/Clientes.txt");
    //        FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
    //        StreamReader reader = new StreamReader(stream);


    //        stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
    //        reader = new StreamReader(stream);

    //        while (reader.Peek() > -1)
    //        {
    //            Cliente cliente = new Cliente();
    //            cliente.Nit = reader.ReadLine();
    //            cliente.Nombre = reader.ReadLine();
    //            cliente.Apellido = reader.ReadLine();
    //            cliente.Direccion = reader.ReadLine();
    //            cliente.Telefono = reader.ReadLine();

    //            Clientes.Add(cliente);
    //        }

    //        reader.Close();

    //        DropDownList1.DataValueField = "Nit";
    //        DropDownList1.DataTextField = "Nit";
    //        DropDownList1.DataSource = Clientes;
    //        DropDownList1.DataBind();
    //    }

    //    void Cargar_Productos()
    //    {
    //        //Txt_Nombre.Text = "Hola";
    //        var archivo = Server.MapPath("~/Productos.txt");
    //        FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
    //        StreamReader reader = new StreamReader(stream);


    //        stream = new FileStream(archivo, FileMode.Open, FileAccess.Read);
    //        reader = new StreamReader(stream);

    //        while (reader.Peek() > -1)
    //        {
    //            Producto producto = new Producto();
    //            producto.Codigo = reader.ReadLine();
    //            producto.Nombre = reader.ReadLine();
    //            producto.Marca = reader.ReadLine();
    //            producto.Descripcion = reader.ReadLine();
    //            producto.Precio_compra = reader.ReadLine();
    //            producto.Precio_Venta = reader.ReadLine();
    //            producto.Existencia = Convert.ToInt16(reader.ReadLine());
    //            producto.Foto = reader.ReadLine();

    //            Productos.Add(producto);
    //        }

    //        reader.Close();

    //        DropDownList2.DataValueField = "Codigo";
    //        DropDownList2.DataTextField = "Nombre";
    //        DropDownList2.DataSource = Productos;
    //        DropDownList2.DataBind();
    //    }

    //    protected void DropDownList1_TextChanged(object sender, EventArgs e)
    //    {
    //        //Txt_Nombre.Text = "Hola";
    //    }

    //    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    //    {
    //        cod_Pd = DropDownList2.SelectedValue;
    //        for (int i = 0; i < Productos.Count; i++)
    //        {
    //            if (Productos[i].Codigo == cod_Pd)
    //            {
    //                Txt_Marca.Text = Productos[i].Marca;
    //                Txt_Desc.Text = Productos[i].Descripcion;
    //            }
    //        }
    //    }
    //}
}