<%@ Page Title="" Language="C#" MasterPageFile="~/InfinityCambio.Master" AutoEventWireup="true" CodeBehind="contato.aspx.cs" Inherits="PrjCasadeCambio.contato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/contatoEstilo.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
    <div class="tituloSobre">
        <span>Contate-nos</span>
        <p>
            Você pode nos mandar uma mensagem a qualquer momento, estaremos felizes e disponíveis para te ajudar quando pudermos.
        </p>
    </div>
    <div class="contato" id="contato">
        <div class="areaDeContato fl">
            <form>
                <asp:Panel ID="pnlForm" runat="server">
                    <p>Nome:<br>
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Insira seu nome."></asp:TextBox><br />

                    Email:<br><asp:TextBox ID="txtDestinatario" runat="server" placeholder="Insira seu email."></asp:TextBox><br />

                    Assunto:<br><asp:TextBox ID="txtAssunto" runat="server" placeholder="Escreva o assunto."></asp:TextBox><br />

                    Sua mensagem:</p><br />
                    <asp:TextBox ID="txtTexto" runat="server" rows="10" cols="44" TextMode="Multiline" placeholder="Escreva aqui..."></asp:TextBox><br />

                   <asp:Button ID="btnEnviar" runat="server" Text="Enviar" style="float: right;" onclick="btnEnviar_Click"></asp:Button>
                </asp:Panel>
                <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            </form>
        </div>
        <div class="telefoneBox fl">
            <div class="descTelefone">
                <p>Aqui os nossos telefones para contato, caso tenha outra dúvida de interesse.</p>
            </div>
            <div class="telNumero fl">
                <span>Comercial:</span>
                <p>55 (13) 99614-4813</p>
            </div>
            <div class="telNumero fl">
                <span>Comercial 2:</span>
                <p>55 (13) 98123-5158</p>
            </div>
        </div>
        <div class="cls"></div>
    </div>
</main>
</asp:Content>
