using System;
using System.Net;
using System.Net.Mail;

namespace LGroup.Helper
{
    public sealed class EmailHelper
    {
        public static void Enviar(String para_, String assunto_, String corpo_)
        {
            var servidor = new SmtpClient("smtp.gmail.com", 587);
            servidor.Credentials = new NetworkCredential("charlesmendes31@gmail.com", "");
            servidor.EnableSsl = true; // Aplicando uma conexão segura (SSL)

            var email = new MailMessage("charlesmendes31@gmail.com", para_);
            email.Subject = assunto_;
            email.Body = corpo_;

            servidor.Send(email);
        }
    }
}
