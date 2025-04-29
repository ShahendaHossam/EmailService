using Application.Dtos;
using Application.IManagers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Application.Managers
{
    public class SendEmailManager : ISendEmailManager
    {
        private readonly IConfiguration _configuration;
        public SendEmailManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmail(SendEmailDto sendEmail)
        {
            var sender = _configuration["EmailSettings:Email"];
            var password = _configuration["EmailSettings:Password"];
            var host = _configuration["EmailSettings:Host"];
            var port = int.Parse(_configuration["EmailSettings:Port"]);
            

            var smtpClient = new SmtpClient();
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;

            smtpClient.Credentials = new NetworkCredential(sender, password);

            var message = new MailMessage(sender!, sendEmail.Reciever, sendEmail.Subject, sendEmail.Body);
            await smtpClient.SendMailAsync(message);

        }
    }
}
