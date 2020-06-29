<%@ Page Title="" Language="C#" MasterPageFile="~/PoS1.Master" AutoEventWireup="true" CodeBehind="Vista_Carro.aspx.cs" Inherits="Proyecto_Final.Vista_Carro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="page-header">
 		    <h1>Productos</h1>
 	    </div>
        <table>
            <tr>
                <td>
                    <div class="form-group">
                     <asp:Label ID="Lbl_Cliente" class="col-lg-2 control-label"  runat="server" Text="Cliente"></asp:Label>
                       <div class="col-lg-10">
                           <asp:Label ID="Lbl_Nit" runat="server" Text="Nit"></asp:Label>
                           <asp:TextBox ID="Txt_Nit" runat="server"></asp:TextBox>
                           <asp:Label ID="Lbl_Nombre" runat="server" Text="Nombre"></asp:Label>
                           <asp:TextBox ID="Txt_Nombre" runat="server"></asp:TextBox>
                           <asp:Label ID="Lbl_Apellido" runat="server" Text="Apellido"></asp:Label>
                           <asp:TextBox ID="Txt_Apellido" runat="server"></asp:TextBox>
                           <asp:Label ID="Lbl_Direccion" runat="server" Text="Direccion"></asp:Label>
                           <asp:TextBox ID="Txt_Direccion" runat="server"></asp:TextBox>
                           <asp:Label ID="Lbl_Telefono" runat="server" Text="Telefono"></asp:Label>
                           <asp:TextBox ID="Txt_Telefono" runat="server"></asp:TextBox>
                           <asp:Label ID="Lbl_Fecha" runat="server" Text="Fecha"></asp:Label>
                           <asp:TextBox ID="Txt_Fecha" runat="server" Enabled="False"></asp:TextBox>
                           <asp:Label ID="Lbl_Total" runat="server" Text="Total"></asp:Label>
                           <asp:TextBox ID="Txt_Total" runat="server" Enabled="False"></asp:TextBox>
                           <asp:Label ID="Lbl_TipoPago" runat="server" Text="Tipo de Pago"></asp:Label>
                           <asp:DropDownList ID="DropDownList1" runat="server">
                               <asp:ListItem>Efectivo</asp:ListItem>
                               <asp:ListItem>Tarjeta</asp:ListItem>
                           </asp:DropDownList>
                       </div>
                    </div>
                </td>
                <td>
                    <div class="form-group">
                     <asp:Label ID="Label2" class="col-lg-2 control-label"  runat="server" Text="Ingresar Nit"></asp:Label>
                       <div class="col-lg-10">
                           <asp:Button ID="Bnt_Nit" runat="server" Text="Ver" OnClick="Bnt_Ver_Click" />    
                       </div>

                    </div>
                   <div class="form-group">
                     <asp:Label ID="Label1" class="col-lg-2 control-label"  runat="server" Text="Compra"></asp:Label>
                       <div class="col-lg-10">
                           <asp:Button ID="Bnt_Comprar" runat="server" Text="Comprar" OnClick="Bnt_Comprar_Click" />    
                       </div>

                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class="table-responsive">
                        <asp:GridView ID="GridView1" class="table table-hover" runat="server"></asp:GridView>
                    </div>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
