using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace PrjCasadeCambio
{
    public partial class conversor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMoedaPri.Items.Add(new ListItem("-", "-1"));
                ddlMoedaPri.Items.Add(new ListItem("Real", "1"));

                ddlMoedaSec.Items.Add(new ListItem("-", "-1"));
                ddlMoedaSec.Items.Add(new ListItem("Dólar", "1"));
                ddlMoedaSec.Items.Add(new ListItem("Euro", "2"));
                ddlMoedaSec.Items.Add(new ListItem("Libra", "3"));
                ddlMoedaSec.Items.Add(new ListItem("Peso Argentino", "4"));
            }
        }

        protected void btnConverter_Click(object sender, EventArgs e)
        {
            #region Declaração das variáveis

            double valor = 0.0;
            string resultado;

            #endregion

            #region Validações
            if (ddlMoedaPri.SelectedIndex <= 0)
            {
                lblResultado.Text = "Selecione a moeda Principal!";
                ddlMoedaPri.Focus();
                return;
            }

            if (ddlMoedaSec.SelectedIndex <= 0)
            {
                lblResultado.Text = "Selecione a moeda Secundária!";
                ddlMoedaSec.Focus();
                return;
            }

            txtValor.Text = txtValor.Text.Trim();

            if (txtValor.Text == "")
            {
                lblResultado.Text = "Digite o Valor!";
                txtValor.Focus();
                return;
            }

            try
            {
                valor = double.Parse(txtValor.Text);
            }
            catch
            {
                lblResultado.Text = "O valor deve ser numérico!";
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }

            valor = double.Parse(txtValor.Text);
            if (valor <= 0)
            {
                lblResultado.Text = "O valor não pode ser menor ou igual a 0!";
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }

            #endregion

            #region Conversão
            //Real para Dólar

            if (ddlMoedaSec.SelectedValue.ToString() == "1")
            {
                double cotacaoDolar = 0.26;
                double valorDolar = 0.0;

                valorDolar = valor * cotacaoDolar;

                CultureInfo regiao = new CultureInfo("en-US");

                lblResultado.Text = string.Format(regiao, "{0:C}", valorDolar);
            }

            //Real para Euro

            if (ddlMoedaSec.SelectedValue.ToString() == "2")
            {
                double cotacaoEuro = 0.23;
                double valorEuro = 0.0;

                valorEuro = valor * cotacaoEuro;

                CultureInfo regiao = new CultureInfo("fr-FR");

                lblResultado.Text = string.Format(regiao, "{0:C}", valorEuro);
            }

            //Real para Libras

            if (ddlMoedaSec.SelectedValue.ToString() == "3")
            {
                double cotacaoLibraEsterlina = 0.20;
                double valorLibraEsterlina = 0.0;

                valorLibraEsterlina = valor * cotacaoLibraEsterlina;

                CultureInfo regiao = new CultureInfo("en-GB");

                lblResultado.Text = string.Format(regiao, "{0:C}", valorLibraEsterlina);
            }

            //Real para Peso Argentino

            if (ddlMoedaSec.SelectedValue.ToString() == "4")
            {
                double cotacaoPesoArgentino = 9.49;
                double valorPesoArgentino = 0.0;

                valorPesoArgentino = valor * cotacaoPesoArgentino;

                CultureInfo regiao = new CultureInfo("es-AR");

                lblResultado.Text = string.Format(regiao, "{0:C}", valorPesoArgentino);
            }

            lblResultado.Text = "O resultado em " + ddlMoedaSec.SelectedItem.ToString() + " é: " + lblResultado.Text;

            #endregion
        }
    }
}