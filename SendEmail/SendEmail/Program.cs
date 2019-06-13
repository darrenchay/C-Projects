using System;
using System.Net;
using System.Net.Mail;

namespace SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string mailBodyString;
            Console.WriteLine("Write what you want to send in the email.");
            mailBodyString = Console.ReadLine();
            Console.WriteLine("Sending Mail");
            Email(mailBodyString);
            Console.WriteLine("Mail Sent");

        }
        public static void Email(string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("darrenchay@gmail.com");
                message.To.Add(new MailAddress("darrenchay@gmail.com"));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("darrenchay@gmail.com", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }
    }
}