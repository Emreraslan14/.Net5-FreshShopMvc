using System.Net;
using System.Net.Mail;

namespace FreshShop.MvcWebUI.Helpers
{
    public static class MailHelper
    {
        public static void SendMail(string to,string title,string message)
        {
            MailMessage msg = new MailMessage("freshshop2023@gmail.com",to);

            msg.Subject = title;
            msg.Body = message;
            msg.IsBodyHtml = true;  //html sayfası olarak mail atabilmemiz için.

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new NetworkCredential("freshshop2023@gmail.com", "Fresh45!_Shop35A");  //Mail atmak için öncelikle
            //login olmak gerektiği için Credentials ile giriş bilgilerini veriyoruz. (Credentials kimlik bilgileri anlamına gelir.)

            smtp.Host = "smtp.gmail.com";  //host ve port değerlerini google'ye x stmp settings yazarak buluyoruz.
            smtp.Port = 587;               
            smtp.EnableSsl = true;  //Http's' üzerinden yapılabilsin diye bu özelliği aktif etmemiz gerek.

            smtp.Send(msg);
        }
    }
}
