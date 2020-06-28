<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Entregas.aspx.cs" Inherits="Proyecto_Final.Entregas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="container">
        <div class="page-header">
 		    <h1>Entregas&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
 	    </div>

         <table>
             <tr>
                 <div class="form-group">
                     <asp:Label ID="Lbl_Entrega" class="col-lg-2 control-label" runat="server" Text="Entregar"></asp:Label>
                     <asp:Label ID="Lbl_Codigo" class="col-lg-2 control-label" runat="server" Text="Codigo"></asp:Label>
                     <asp:TextBox ID="Txt_Cod" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                     <asp:Label ID="Lbl_Nombre" class="col-lg-2 control-label" runat="server" Text="Nombre"></asp:Label>
                     <asp:TextBox ID="Txt_Nombre" class="form-control" runat="server" Enabled="False"></asp:TextBox>
                     <div class="col-lg-offset-2 col-lg-10">
                         <asp:Button ID="Btn_Entregar" class="btn btn-success" runat="server" Text="Entregar" OnClick="Btn_Entregar_Click" />
                         </div>
                 </div>
             </tr>
             <tr>
                 <td>
                     <div class="form-group">
                     <asp:Label ID="Lbl_Entregadas" class="col-lg-2 control-label" runat="server" Text="Entregadas"></asp:Label>
                     </div>

                     <div class="table-responsive">
                         <asp:GridView ID="GridView1" class="table table-hover" runat="server"></asp:GridView>
                     </div>
                 </td>
                 <td>
                     <div class="form-group">
                     <asp:Label ID="Lbl_Pendiente" class="col-lg-2 control-label" runat="server" Text="Pendientes"></asp:Label>
                     </div>

                     <div class="table-responsive">
                         <asp:GridView ID="GridView2" class="table table-hover" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView2_SelectedIndexChanged"></asp:GridView>
                     </div>
                 </td>
             </tr>
         </table>
     </div>
</asp:Content>
