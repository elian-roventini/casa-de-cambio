<%@ Page Title="" Language="C#" MasterPageFile="~/InfinityCambio.Master" AutoEventWireup="true" CodeBehind="conversor.aspx.cs" Inherits="PrjCasadeCambio.conversor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/conversorEstilo.css" rel="stylesheet" type="text/css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article class="Box">
		    <div class="contBox">
			    <h1>Conversor de moedas</h1>
			    <table border="0" align="center">
			    <tr>
				    <td class="col1_1">De:</td>
				    <td>
                        <asp:DropDownList ID="ddlMoedaPri" runat="server"></asp:DropDownList>
                    </td>
                    <td class="para">Para: </td>
                    <td>
                        <asp:DropDownList ID="ddlMoedaSec" runat="server"></asp:DropDownList>
                    </td>
			    </tr>

			    <tr>
				    <td class="para">Insira o valor: </td>
				    <td><asp:TextBox ID="txtValor" runat="server"></asp:TextBox></td>
			    </tr>
                
			    <tr>
				    <td colspan="2" class="direita">
                        <asp:Button ID="btnConverter" class="btnConverter" runat="server" Text="Converter" onclick="btnConverter_Click"></asp:Button>
				    </td>
			    </tr>

			    <tr>
				    <td colspan="2" class="centro">
                        <asp:Label ID="lblResultado" class="resultado" runat="server" Text="&nbsp;"></asp:Label>
				    </td>
			    </tr>
			    </table>
		    </div>
	    </article>
</asp:Content>
