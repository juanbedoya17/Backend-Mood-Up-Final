using System.Net;
using System.Net.Mail;


namespace MoodUP_final.Services
{
    public class EmailService
    {
        private readonly  IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task EnviarCorreo(string destino, string asunto, string mensaje)
        {
           var email = _config["EmailSettings:Email"];
           var password = _config["EmailSettings:Password"];
            var host = _config["EmailSettings:Host"];
            var port = int.Parse(_config["EmailSettings:Port"]);

            var smtp = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(email, password),
                EnableSsl = true
            };

            var mail = new MailMessage(email, destino, asunto, mensaje);
            mail.IsBodyHtml = true;

            await smtp.SendMailAsync(mail);
        }
    }
}
