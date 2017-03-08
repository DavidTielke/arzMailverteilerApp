using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSending.Contract;

namespace MailSending.Print
{
    public class MailPrinter : IMailSender
    {
        public void Send()
        {
            Console.WriteLine("Mail ausdrucken");
        }
    }
}
