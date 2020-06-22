<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes_View.aspx.cs" Inherits="Proyecto_Final.Clientes_View" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="container">
        <div class="page-header">
 		    <h1>Clientes</h1>
 	    </div>

         <div class="table-responsive">
             <asp:GridView ID="GridView1" class="table table-hover" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
         </div>
        </div>
</asp:Content>
