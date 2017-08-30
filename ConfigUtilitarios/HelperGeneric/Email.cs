using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace ConfigUtilitarios
{
    public class Email
    {
        public bool SendEmail(string emailFrom, string pass, string displayName, string emailTo, string subject, string body, string mailServer, int port)
        {
            var log = new Log();
            bool enviado = false;

            try
            {
                var fromAddress = new MailAddress(emailFrom, displayName);
                var toAddress = new MailAddress(emailTo, emailTo);

                var smtp = new SmtpClient
                {
                    Host = mailServer,
                    Port = port,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, pass),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    try
                    {
                        smtp.Send(message);
                        enviado = true;
                        message.Dispose();
                        log.ArchiveLog("Utilitarios: Send Email : ", "Se envió el mail exitosamente: " + emailTo);
                    }
                    catch (SmtpException exc)
                    {
                        log.ArchiveLog("Utilitarios: Send Email (client.Send(message)) : ", exc.Message.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                log.ArchiveLog("Utilitarios: Send Email : ", ex.Message.ToString());
            }
            return enviado;
        }
    }
}
