using ALXCourseHomework.MailingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework
{
    public class Homework1Test
    {
        public static void Run()
        {

            //var service = new EmailService();

            //  List<Email> lista = new List<Email>();

            // lista.Add(new() { EmailFrom = "tester@firma.pl", EmailTo = "aa@wp.pl", EmailSubject = "test123", EmailMessage = "TESTOWA WIADOMOść" });
            // lista.Add(new() { EmailFrom = "tester@gmail.com", EmailTo = "abc@vot.pl", EmailSubject = "Jakieś takie", EmailMessage = "TESTOWA WIADOMOść\n" });
            // lista.Add(new() { EmailFrom = "tester@yahoo.com", EmailTo = "aa@wp.pl", EmailSubject = "Może być", EmailMessage = "Tak jak ostatnio\n" });
            //  lista.Add(new() { EmailFrom = "tester@hotmail.com", EmailTo = "bb@o2.pl.pl", EmailSubject = "Lista zakupów", EmailMessage = "\n1. Chleb\n 2. Ser żółty\n 3. Ketchup\n 4. Kefri\n" });
            // lista.Add(new() { EmailFrom = "tester@o2.pl", EmailTo = "cc@gmail.com", EmailSubject = "Zawiadomienie", EmailMessage = "Niedopłata do mediów\n" });


            // foreach (var email in lista)
            //  {

            //       service.SendEmail(email);
            //  }


            var em1 = new EmailService();
            em1.SendEmail(new() { EmailFrom = "tester@firma.pl", EmailTo = "aa@wp.pl", EmailSubject = "test123", EmailMessage = "TESTOWA WIADOMOść\n"});
            em1.SendEmail(new() { EmailFrom = "tester@gmail.com", EmailTo = "abc@vot.pl", EmailSubject = "Jakieś takie", EmailMessage = "TESTOWA WIADOMOść\n" });
            em1.SendEmail(new() { EmailFrom = "tester@yahoo.com", EmailTo = "aa@wp.pl", EmailSubject = "Może być", EmailMessage = "Tak jak ostatnio\n" });
            em1.SendEmail(new() { EmailFrom = "tester@hotmail.com", EmailTo = "bb@o2.pl.pl", EmailSubject = "Lista zakupów", EmailMessage = "\n1. Chleb\n 2. Ser żółty\n 3. Ketchup\n 4. Kefri\n" });
            em1.SendEmail(new() { EmailFrom = "tester@o2.pl", EmailTo = "cc@gmail.com", EmailSubject = "Zawiadomienie", EmailMessage = "Niedopłata do mediów\n" });

             
            




        }
    }
}
