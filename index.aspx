<%@ Page Title="" Language="C#" MasterPageFile="~/InfinityCambio.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PrjCasadeCambio.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="shortcut icon" href="images/icon/favicon.ico" type="image/x-icon">
    <link rel="icon" href="images/icon/favicon.ico" type="image/x-icon">
    <link href="css/indexEstilo.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<main>
<!-- Carrosel -->
    <div class="banner cor5">
        <div class="logoBanner">
            <img src="images/logo/LogoInfinityCambio.png" height="200">
        </div>
    </div>
<!-- Carrosel -->

    <div class="apresentacao">
        <div class="tituloApresentacao">
            <p>Como funciona o Infinity Câmbio</p>
        </div>
        <div class="descTituloApresentacao">
            <p>Aqui, a Infinity Câmbio apresenta as nossas características e como você pode navegar pelo nosso site tranquilamente, de forma rápida.</p>
        </div>
        <div class="contApresentacao">
            <div class="divisao fl">
                <div class="box1 fl">
                </div>
                <div class="pBox fl">
                    <span>Conversor</span>
                    <br>
                    <br>
                    Converta com total segurança. Temos um conversor ágil e prático a sua disposição.

                    Basta escolher a moeda que você precisa e pronto!
                </div>
            </div>
            <div class="divisao fl">
                <div class="box2 fl">
                </div>
                <div class="pBox fl">
                    <span>Segurança</span>
                    <br>
                    <br>
                    Contamos com uma segurança totalmente garantida. Navegue pelo site tranquilamente!
                </div>
            </div>
            <div class="divisao fl">
                <div class="box3 fl">
                </div>
                <div class="pBox fl">
                    <span>Contato</span>
                    <br>
                    <br>
                    Entre em contato conosco sempre que precisar, resolvemos o seu problema o mais rápido possível.
                </div>
            </div>
        </div>
        <div class="cls"></div>
    </div>
</main>
</asp:Content>
