using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Data.MailServices
{
    public abstract class MasterMailService
    {
        private SmtpClient smtpClient;
        protected string SenderMail { get; set; }
        protected string Password { get; set; }
        protected string Host { get; set; }
        protected int Port { get; set; }
        protected bool Ssl { get; set; }

        protected void InitializeSmptClient()
        {
            //this is the configuration for the SMTP
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(SenderMail, Password);
            smtpClient.Host = Host;
            smtpClient.Port = Port;
            smtpClient.EnableSsl = Ssl;
        }

        public void SendEmail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(SenderMail);
                foreach (string mail in recipientMail)
                {
                mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.High;
                smtpClient.Send(mailMessage);
            }
            catch (Exception e)
            {
                throw e;               
            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
