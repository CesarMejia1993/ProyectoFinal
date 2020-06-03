<%@ Page Title="Productos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ProyectoTienda.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Reguistrar Un nuevo Producto</h2>
        <p>&nbsp;</p>
        <p>
            <table style="width:100%;">
               
                <tr>
                    <td style="width: 221px; height: 19px;">Código del producto</td>
                    <td class="modal-sm" style="width: 169px; height: 19px;">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 19px"></td>
                </tr>
                <tr>
                    <td style="width: 221px; height: 19px;">Nombre del producto</td>
                    <td class="modal-sm" style="width: 169px; height: 19px;">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 19px"></td>
                </tr>
                <tr>
                    <td style="width: 221px; height: 19px;">Marca</td>
                    <td class="modal-sm" style="width: 169px; height: 19px;">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 19px"></td>
                </tr>
               
                <tr>
                    <td style="width: 221px; height: 19px;">Descripción del producto</td>
                    <td class="modal-sm" style="width: 169px; height: 19px;">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 19px"></td>
                </tr>
                <tr>
                    <td style="width: 221px; height: 31px;">Imagen del producto</td>
                    <td class="modal-sm" style="width: 169px; height: 31px;">
                        <asp:Button ID="Button1" runat="server" Height="49px" Text="Cargar Imagen" Width="185px" />
                    </td>
                    <td style="height: 31px"></td>
                </tr>
                <tr>
                    <td style="width: 221px; height: 19px;">Precio de Compra.</td>
                    <td class="modal-sm" style="width: 169px; height: 19px;">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 19px"></td>
                </tr>
                <tr>
                    <td style="width: 221px">Precio de Venta.</td>
                    <td class="modal-sm" style="width: 169px">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td style="width: 221px; height: 19px;">Cantidad en existencia.</td>
                    <td class="modal-sm" style="width: 169px; height: 19px;">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                     </td>
                    <td style="height: 19px"></td>
                </tr>
            </table>
        </p>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button2" runat="server" Text="Guardar" />
        </p>
    </div>

    
</asp:Content>