using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DBProvider.Model;
using System.Windows.Forms;

namespace TrackingStudentProgress.Notifications
{
    public class Notifications
    {
        public static void Send(NotificationModel notification)
        {
            foreach (var notifEmail in notification.Email)
            {
                SendEmailAsync(notifEmail, notification.Subject, notification.Body).GetAwaiter();
            }
           
        }
        private static async Task SendEmailAsync(string Email,string subject, string body)
        {
            MailAddress from = new MailAddress("andrey.moskvin.99@list.ru", "Отслеживание успеваемости обучающихся");
            MailAddress to = new MailAddress(Email);
            MailMessage m = new MailMessage(from, to);
            m.Subject = subject;
            m.Body = body;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.list.ru", 25);
            smtp.Credentials = new NetworkCredential("andrey.moskvin.99@list.ru", "EkJZL72csctFT678qM5x");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
