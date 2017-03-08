using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSending
{
    public class MailSender
    {
        private readonly MailDistributor _mailDistributor;

        public MailSender(MailDistributor mailDistributor)
        {
            _mailDistributor = mailDistributor;
        }

        public void Send()
        {
            Console.WriteLine("Email wird vetrsendet");
            _mailDistributor.SentComplete();
        }
    }
}
