using System.Net;
using System.Net.Mail;

public class EmailService
{
    public void SendEmail(string toEmail, string subject, string body)
    {
        // Configuratie van de SMTP-client
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com") // Pas dit aan naar jouw SMTP-server
        {
            Port = 587, // Gebruik de juiste poort (TLS)
            Credentials = new NetworkCredential("lvkspam13@gmail.com", "Gmail1304!"),
            EnableSsl = true  // Zorgt voor een beveiligde verbinding
        };

        // E-mailbericht opstellen
        MailMessage mailMessage = new MailMessage
        {
            From = new MailAddress("lvkspam13@gmail.com"),
            Subject = subject,
            Body = body,
            IsBodyHtml = true  // Zet op 'true' als je HTML gebruikt in je e-mail
        };
        mailMessage.To.Add(toEmail);

        // Verzend de e-mail
        smtpClient.Send(mailMessage);
    }
}
