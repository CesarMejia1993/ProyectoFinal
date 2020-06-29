<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Prod_Vendido.aspx.cs" Inherits="Proyecto_Final.Prod_Vendido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
		<div class="page-header">
		  <h1>Producto mas vendido</h1>
		</div>

		<div class="table-responsive">
            <asp:GridView ID="GridView1" class="table table-hover" runat="server"></asp:GridView>
		</div>

	</div>

</asp:Content>
