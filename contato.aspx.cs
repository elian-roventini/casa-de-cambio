using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Bibliotecas para uso de Email

using System.Net;
using System.Net.Mail;

#endregion

#region Bibliotecas Regex

using System.Text.RegularExpressions;

#endregion

namespace PrjCasadeCambio
{
    public partial class contato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            #region Programação

            #region Declaração de Variáveis
            string remetente = "";
            string senha = "";
            string nome = "";
            string destinatario = "";
            string assunto = "";
            string texto = "";

            #endregion

            #region Atribuição dos Valores
            remetente = "contatoInfinityCambio@outlook.com";
            senha = "6295725IC";
            nome = txtNome.Text;
            destinatario = txtDestinatario.Text;
            assunto = txtAssunto.Text;
            texto = txtTexto.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(destinatario);
            #endregion

            #region Validação

            txtDestinatario.Text = txtDestinatario.Text.Trim();

            if (txtNome.Text == "")
            {
                lblMensagem.Text = "O nome é obrigatório!";
                txtNome.Focus();
                return;
            }

            if (txtDestinatario.Text == "")
            {
                lblMensagem.Text = "Digite seu E-mail!";
                txtDestinatario.Focus();
                return;
            }

            if (match.Success)
            {
            }
            else
            {
                lblMensagem.Text = "O formato do E-mail está incorreto!";
                txtDestinatario.Focus();
                return;
            }

            if (txtAssunto.Text == "")
            {
                lblMensagem.Text = "Digite o Assunto do E-mail!";
                txtAssunto.Focus();
                return;
            }

            if (txtTexto.Text == "")
            {
                lblMensagem.Text = "Digite sua mensagem!";
                txtTexto.Focus();
                return;
            }

            #endregion

            #region Configurações do Remetente
            SmtpClient client = new SmtpClient();

            client.Credentials = new NetworkCredential(remetente, senha);

            #region Configuração do Servidor SMTP do OUTLOOK
            client.Host = "smtp-mail.outlook.com";
            client.Port = 587;
            client.EnableSsl = true;
            #endregion

            #endregion

            #region Configuração de Email
            MailMessage novoemail = new MailMessage();
            novoemail.To.Add(remetente);
            novoemail.To.Add(destinatario);
            novoemail.From = new MailAddress(remetente, "Contato via Site", System.Text.Encoding.UTF8);
            novoemail.Subject = assunto;
            novoemail.SubjectEncoding = System.Text.Encoding.UTF8;
            novoemail.Body = "<html><body><b><i>" + texto + "<br/><br /> E-mail enviado de: " + nome + "<br /> E-mail: " + destinatario + "</i></b></body></html>";
            novoemail.BodyEncoding = System.Text.Encoding.UTF8;
            novoemail.IsBodyHtml = true;
            novoemail.Priority = MailPriority.High;
            #endregion

            #region Envio de Email
            pnlForm.Visible = false;
            try
            {
                client.Send(novoemail);
                lblMensagem.Text = "Email Enviado com sucesso.";
            }
            catch
            {
                lblMensagem.Text = "Erro no Envio do Email.";
            }
            #endregion

            #endregion

        }
    }
}