using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvioEmailsAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Evitar múltiplos cliques enquanto a aplicação está em andamento
            btnEnviar.Enabled = false;

            // Acesso remetente
            string emailRemetente = txtEmailRemetente.Text;
            string senhaRemetente = txtSenhaRemetente.Text;

            // E-mail destinatário
            string emailDestinatario = txtEmailDestinatario.Text;

            // Assunto
            string emailAssunto = txtAssuntoEmail.Text;

            // Mensagem
            string emailMensagem = txtConteudoEmail.Text;

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(emailRemetente);
            mail.To.Add(emailDestinatario); // PARA
            mail.Subject = emailAssunto; //ASSUNTO
            mail.Body = emailMensagem; // CORPO DO E-MAIL

            using (var smtp = new SmtpClient("smtp-mail.outlook.com", 587))
            {
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(emailRemetente, senhaRemetente);

                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("E-mail enviado!");
                    btnEnviar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnEnviar.Enabled = true;
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}


