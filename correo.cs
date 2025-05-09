using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olamuchogusto
{
    internal class correo
    {
        private string smtpServer = "smtp.office365.com"; // Servidor SMTP de Gmail
        private int smtpPort = 587; // Puerto SMTP para TLS
        private string smtpUser = "113149@alumnouninter.mx"; // Tu correo electrónico
        private string smtpPassword = "4Ngela666!"; // Tu contraseña de aplicación

        public void EnviarCorreo(string error)
        {
            try
            {
                using (var clienteSmtp = new SmtpClient(smtpServer, smtpPort))
                {
                    clienteSmtp.Credentials = new NetworkCredential(smtpUser, smtpPassword);
                    clienteSmtp.EnableSsl = true;

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(smtpUser),
                        Subject = "Error en la aplicación",
                        Body = error,
                        IsBodyHtml = false
                    };
                    mailMessage.To.Add("ecorrales@uninter.edu.mx"); // Correo del destinatario

                    clienteSmtp.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al enviar el correo: {ex.Message}");
            }
        }
    }
}
