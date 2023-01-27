using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    public static class EmailAPI
    {
        private static SmtpClient smtp = new SmtpClient();
        private static MimeMessage email = new MimeMessage();
        private static Multipart multipart = new Multipart();

        private static void Reset()
        {
            smtp = new SmtpClient();
            email = new MimeMessage();
            multipart = new Multipart();
        }

        public static void DodajPrilog(string path)
        {
            var attachment = new MimePart("image", "gif")
            {
                Content = new MimeContent(File.OpenRead(path)),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Base64,
                FileName = Path.GetFileName(path)
            };
            multipart.Add(attachment);
        }

        public static void NapraviEmail(string from, string to, string subject, string text)
        {
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            var body = new TextPart(TextFormat.Html) { Text = $"<p>{text}<p>" };
            multipart.Add(body);
        }

        public static void Posalji()
        {
            email.Body = multipart;
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("sebastijan.bicak@gmail.com", "uayccjrwqgsclrce");
            smtp.Send(email);
            smtp.Disconnect(true);
            Reset();
        }
    }
}
