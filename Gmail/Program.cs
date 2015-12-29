using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gmail
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string kad = "";
                string pass = "";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
               
                Console.WriteLine("Kullanıcı Adınız :");
                kad = Console.ReadLine();
                Console.WriteLine("Şifreniz");
                pass = Console.ReadLine();

                smtp.Credentials = new NetworkCredential("kad", "pass");


                Console.WriteLine("Kime :");
                MailAddress to = new MailAddress(Console.ReadLine());

                Console.WriteLine("Kimden : " + kad);
                MailAddress from = new MailAddress(kad);

                MailMessage mail = new MailMessage(from, to);
                Console.WriteLine("Konu :");
                mail.Subject = Console.ReadLine();

                Console.WriteLine("Mesajınız :");
                mail.Body = Console.ReadLine();




                Console.WriteLine("Mail Gönderildi...");
                smtp.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not send e-mail. Exception caught: " + e);
                Console.ReadLine();
            }
        }
    }
}
