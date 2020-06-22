<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Proyecto_Final.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
	 <div class="page-header">
	  <h1>Nuevo Cliente</small>
         </h1>
	 </div>
   
        
           <div class="form-group">
                <asp:Label ID="Lbl_Nit" class="col-lg-2 control-label" runat="server" Text="Nit"></asp:Label>
            <div>
                <asp:TextBox ID="Txt_Nit" class="form-control" runat="server"></asp:TextBox>
                </div>
           </div>

        <div class="form-group">
                <asp:Label ID="Lbl_Nombre" class="col-lg-2 control-label" runat="server" Text="Nombre"></asp:Label>
                <div>
                <asp:TextBox ID="Txt_Nombre" class="form-control" runat="server"></asp:TextBox>
                </div>
        </div>

       <div class="form-group">
                <asp:Label ID="Lbl_Apellido" class="col-lg-2 control-label" runat="server" Text="Apellido"></asp:Label>
            <div>
                <asp:TextBox ID="Txt_Apellido" class="form-control" runat="server"></asp:TextBox>
                </div>
       </div>
        <div class="form-group">
                <asp:Label ID="Lbl_Direccion" class="col-lg-2 control-label" runat="server" Text="Direccion"></asp:Label>
          <div> 
                <asp:TextBox ID="Txt_Direccion" class="form-control" runat="server"></asp:TextBox>
              </div>
           </div>
        <div class="form-group">
                <asp:Label ID="Lbl_Telefono" class="col-lg-2 control-label" runat="server" Text="Telefono"></asp:Label>
            <div>
                <asp:TextBox ID="Txt_Telefono" class="form-control" runat="server"></asp:TextBox>
            </div>
           </div>
        <div class="form-group">
                <asp:Label ID="Lbl_Guardar" class="col-lg-2 control-label" runat="server" Text="Guardar"></asp:Label>
            <div>
                <asp:Button ID="Btn_Guardar" class="form-control" runat="server" Text="Guardar" OnClick="Btn_Guardar_Click" />
                </div>
            </div>
    

</asp:Content>
