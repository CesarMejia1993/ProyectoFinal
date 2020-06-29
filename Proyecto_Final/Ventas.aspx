<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="Proyecto_Final.Ventas1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="page-header">
 		    <h1>Ventas</h1>
 	    </div>
    </div>

    <table class="table table-hover" >
          <tr>
            <td>
                <div class="page-header">
 		           <h3>Venta</h3>
 	            </div>
                <div class="form-group">
                    <asp:Label ID="Lbl_Codigo" class="col-lg-2 control-label" runat="server" Text="Codigo Venta"></asp:Label>
                    
                        <asp:Label ID="Lbl_Cod"  runat="server" Text="199"></asp:Label>
                </div>
            </td>
          </tr>
          <tr>
              <td>
               <div class="form-group">
                     <asp:Label ID="Lbl_Cliente" class="col-lg-2 control-label"  runat="server" Text="Cliente"></asp:Label>
                   <div class="col-lg-10">
                       <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" OnTextChanged="DropDownList1_TextChanged"></asp:DropDownList>
                       <asp:Label ID="Lbl_Nombre" runat="server" Text="Nombre"></asp:Label>
                       <asp:TextBox ID="Txt_Nombre" runat="server" Enabled="False"></asp:TextBox>
                       <asp:Label ID="Lbl_Fecha" runat="server" Text="Fecha"></asp:Label>
                       <asp:TextBox ID="Txt_Fecha" runat="server" Enabled="False"></asp:TextBox>
                       <asp:Label ID="Lbl_Total" runat="server" Text="Total"></asp:Label>
                       <asp:TextBox ID="Txt_Total" runat="server" Enabled="False"></asp:TextBox>
                       <asp:Label ID="Lbl_TipoPago" runat="server" Text="Tipo de Pago"></asp:Label>
                       <asp:DropDownList ID="DropDownList3" runat="server">
                           <asp:ListItem>Efectivo</asp:ListItem>
                           <asp:ListItem>Tarjeta</asp:ListItem>
                       </asp:DropDownList>
                       <asp:Label ID="Lbl_Estado" runat="server" Text="Estado"></asp:Label>
                       <asp:TextBox ID="Txt_Estado" runat="server" Enabled="False"></asp:TextBox>
                   </div>
               </div>
               <div class="form-group">
                   <asp:Label ID="Label1" runat="server" Text="Terminar"></asp:Label>
                   <div>
                       <asp:Button ID="Bnt_Guardar" runat="server" Text="Guardar" OnClick="Bnt_Guardar_Click" />
                   </div>
               </div>

              </td>
          </tr>
        <tr>
            <td>
                <div class="form-group">
                    <asp:Label ID="Lbl_Producto" class="col-lg-2 control-label" runat="server" Text="Producto"></asp:Label>
                    <div class="col-lg-10" >
                        <asp:DropDownList ID="DropDownList2" AutoPostBack="True" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>                     
                        <asp:Label ID="Lbl_Nombre_p" runat="server" Text="Nombre"></asp:Label>
                       <asp:TextBox ID="Txt_Nombre_p" runat="server" Enabled="False"></asp:TextBox>
                        <asp:Label ID="Lbl_Marca" runat="server" Text="Marca"></asp:Label>
                       <asp:TextBox ID="Txt_Marca" runat="server" Enabled="False"></asp:TextBox>
                        <asp:Label ID="Lbl_Descripcion" runat="server" Text="Descripcion"></asp:Label>
                       <asp:TextBox ID="Txt_Desc" runat="server" Enabled="False"></asp:TextBox> 
                       <asp:Label ID="Lbl_Precio" runat="server" Text="Precio"></asp:Label>
                       <asp:TextBox ID="Txt_Precio" runat="server" Enabled="False"></asp:TextBox>
                        <asp:Label ID="Lbl_Cant" runat="server" Text="Cantidad"></asp:Label>
                       <asp:TextBox ID="Txt_cant" runat="server" Enabled="True"></asp:TextBox>
                        <asp:Button ID="Btn_Agregar" runat="server" Text="Agregar" OnClick="Btn_Agregar_Click" />
                    </div>
                </div>
            </td>
        </tr>
          <tr>
              <td>
              <asp:GridView ID="GridView1"  class="table table-hover" runat="server"></asp:GridView>
              </td>
          </tr>
    </table>


</asp:Content>
