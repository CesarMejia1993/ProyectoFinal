<%@ Page Title="Cliente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ProyectoTienda.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Reguistrar Clientes</h2>
        <p>&nbsp;</p>
        <p>
            <table style="width:100%;">
               
               
                
               
                <tr>
                    <td style="width: 221px; height: 19px;">NIT</td>
                    <td class="modal-sm" style="width: 169px; height: 19px;">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 19px"></td>
                </tr>
                <tr>
                    <td style="width: 221px; height: 31px;">Nombre</td>
                    <td class="modal-sm" style="width: 169px; height: 31px;">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 31px"></td>
                </tr>
                <tr>
                    <td style="width: 221px; height: 19px;">Apellido</td>
                    <td class="modal-sm" style="width: 169px; height: 19px;">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    </td>
                    <td style="height: 19px"></td>
                </tr>
                <tr>
                    <td style="width: 221px">Direccion</td>
                    <td class="modal-sm" style="width: 169px">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td style="width: 221px; height: 19px;">Telefono</td>
                    <td class="modal-sm" style="width: 169px; height: 19px;">
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                     </td>
                    <td style="height: 19px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="Guardar" />
                     </td>
                </tr>
            </table>
        </p>
        <p>&nbsp;</p>
    </div>

    
</asp:Content>