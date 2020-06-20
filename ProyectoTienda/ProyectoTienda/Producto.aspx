<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="Proyecto_Final.Producto1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
	 <div class="page-header">
	  <h1>Nuevo Producto</small>
         </h1>
	 </div>
    <table>
        
        <div class="form-group">
                <asp:Label ID="Lbl_Nombre" class="col-lg-2 control-label" runat="server" Text="Nombre"></asp:Label>
                <div>
                <asp:TextBox ID="Txt_Nombre" class="form-control" runat="server"></asp:TextBox>
                </div>
        </div>
        <div class="form-group">
                <asp:Label ID="Label3" class="col-lg-2 control-label" runat="server" Text="Marca"></asp:Label>
            <div>
                <asp:TextBox ID="Txt_Marca" class="form-control" runat="server"></asp:TextBox>
                </div>
           </div>
        <div class="form-group">
                <asp:Label ID="Lbl_Descripcion" class="col-lg-2 control-label" runat="server" Text="Descripcion"></asp:Label>
            <div>
                <asp:TextBox ID="Txt_Descripcion" class="form-control" runat="server"></asp:TextBox>
                </div>
           </div>
       <div class="form-group">
                <asp:Label ID="Lbl_Compra" class="col-lg-2 control-label" runat="server" Text="Precio Compra"></asp:Label>
            <div>
                <asp:TextBox ID="Txt_Compra" class="form-control" runat="server"></asp:TextBox>
                </div>
       </div>
        <div class="form-group">
                <asp:Label ID="Lbl_Venta" class="col-lg-2 control-label" runat="server" Text="Precio Venta"></asp:Label>
          <div> 
                <asp:TextBox ID="Txt_Venta" class="form-control" runat="server"></asp:TextBox>
              </div>
           </div>
        <div class="form-group">
                <asp:Label ID="Lbl_Existencia" class="col-lg-2 control-label" runat="server" Text="Existencia"></asp:Label>
            <div>
                <asp:TextBox ID="Txt_Existencia" class="form-control" runat="server"></asp:TextBox>
            </div>
           </div>
       <div class="form-group">
                <asp:Label ID="Lbl_Imagen" class="col-lg-2 control-label"  runat="server" Text="Imagen"></asp:Label>
            <div>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                </div>
            </div>
        <div class="form-group">
                <asp:Label ID="Lbl_Guardar" class="col-lg-2 control-label" runat="server" Text="Guardar"></asp:Label>
            <div>
                <asp:Button ID="Btn_Guardar" class="form-control" runat="server" Text="Guardar" OnClick="Btn_Guardar_Click" />
                </div>
            </div>
    </table>
</asp:Content>
