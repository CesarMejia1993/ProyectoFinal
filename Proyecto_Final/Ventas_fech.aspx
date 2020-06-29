<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ventas_fech.aspx.cs" Inherits="Proyecto_Final.Ventas_fech" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
		<div class="page-header">
		  <h1>Producto mas vendido</h1>
		</div>
		<table>
			<tr>
				<td>
				<div class="form-group" >
            <asp:Label ID="Lbl_inicial" runat="server" Text="INICIO"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
		</div>
		<div class="form-group">
            <asp:Label ID="Lbl_final" runat="server" Text="FINAL"></asp:Label>
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
		</div>
					</td>
				<td>
		 <div class="form-group">
         <div class="col-lg-offset-2 col-lg-10">
             <asp:Button ID="Btn_Buscar" runat="server" Text="VENTAS" OnClick="Btn_Buscar_Click" />	 
		 </div>
			 </div>
					
					</td>
			</tr>
			<tr>
				<div class="table-responsive">
            <asp:GridView ID="GridView1"  class="table table-hover"  runat="server"></asp:GridView>	
		</div>
			</tr>
		</table>
		<div class="form-group" >
            <asp:Label ID="Lbl_Total" class="col-lg-2 control-label"  runat="server" Text="Total Ganancias Q"></asp:Label>	
			
                <asp:TextBox ID="Txt_Ganancias" class="form-control" runat="server" Enabled="False"></asp:TextBox>
		</div>
		
		</div>
</asp:Content>
