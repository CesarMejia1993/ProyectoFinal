<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto_View.aspx.cs" Inherits="Proyecto_Final.Producto_View" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="page-header">
 		    <h1>Productos</h1>
 	    </div>

         <div class="table-responsive">
             <asp:GridView ID="GridView1" class="table table-hover" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
             </asp:GridView>
         </div>
        <div>
            <asp:Image ID="Image1" width="200" height="200" runat="server" />
        </div>
    </div>
</asp:Content>
