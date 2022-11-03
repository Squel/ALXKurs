using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MailingService
{
    public class EmailService
    {
        public void SendEmail(Email arg0)
        {
           
            Console.WriteLine("The email has been sent");
            Console.WriteLine($"From: {arg0.EmailFrom}");
            Console.WriteLine($"To: {arg0.EmailTo}");
            Console.WriteLine($"Subject: {arg0.EmailSubject}");
            Console.WriteLine($"Message: {arg0.EmailMessage}");
        }
        

    }
}
