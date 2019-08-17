﻿using System.Net;
using System.Net.Mail;

namespace JBD.MonitorCozinha.WebAdmin.Services
{
    public class EmailService
    {
        public bool EnvioEmail(string email, string mensagem)
        {
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("jbelodelf@gmail.com");

                mail.Subject = "Monitor de Cozinha - Usuário operacional";
                mail.IsBodyHtml = true;
                mail.Body = mensagem;
                mail.To.Add(email);
                //Attachment att = new Attachment("C:\\diretorio\\arquivo.pdf");
                //mail.Attachments.Add(att);
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("jbelodelf@gmail.com", "jbelo352");
                smtp.Send(mail);
            }
            return true;
        }
    }
}