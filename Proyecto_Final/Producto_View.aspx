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
        <div class="form-group">
                   <asp:Label ID="Lbl_Codigo" class="col-lg-2 control-label" runat="server" Text="Codigo"></asp:Label>
            <div class="col-lg-10">
                <asp:Label ID="Lbl_Cod" runat="server" Text="1"></asp:Label>
            </div>
            </div>
        <table class="table table-hover" >
          <tr>
            <td>
                <div class="page-header">
 		            <h3>Imagen</h3>
 	            </div>
                <div>
                    <asp:Image ID="Image1" width="200" height="200" runat="server" />
                </div>
            </td>
            <td><!--Actualizar Precios-->
                <div class="page-header">
 		           <h3>Actualizacion</h3>
 	            </div>
                <div class="form-group">
                    <asp:Label ID="Lbl_Precio" class="col-lg-2 control-label" runat="server" Text="Precio"></asp:Label>            
                    <div class="col-lg-10">
                        <asp:TextBox ID="Txt_Precio" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group" >
                    <asp:Label ID="Lbl_Existencia" class="col-lg-2 control-label" runat="server" Text="Existencia"></asp:Label>                
                    <div class="col-lg-10">
                        <asp:TextBox ID="Txt_Existencia" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-lg-offset-2 col-lg-10"> 
                    <asp:Button ID="Btn_Actualizar" class="btn btn-success" runat="server" Text="Actualizar" OnClick="Btn_Actualizar_Click" />
                    </div>
                </div>
            </td>
            <td>
                <div class="page-header">
 		           <h3>Editar</h3>
 	            </div>

                <div class="form-group">
                    <asp:Label ID="Lbl_Nombre" class="col-lg-2 control-label" runat="server" Text="Nombre"></asp:Label>               
                    <div class="col-lg-10">
                       <asp:TextBox ID="Txt_Nombre" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                   <asp:Label ID="Lbl_Marca" class="col-lg-2 control-label" runat="server" Text="Marca"></asp:Label>                
                    <div class="col-lg-10">
                       <asp:TextBox ID="Txt_Marca" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                   <asp:Label ID="Lbl_Descripcion" class="col-lg-2 control-label" runat="server" Text="Descripcion"></asp:Label>                
                    <div class="col-lg-10">
                       <asp:TextBox ID="Txt_Descripcion" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-lg-offset-2 col-lg-10">
                        <asp:Button ID="Btn_Editar" class="btn btn-success" runat="server" Text="Editar" OnClick="Btn_Editar_Click" />
                    </div>
                </div>

              </td>
          </tr>
        </table>
    </div>
</asp:Content>
