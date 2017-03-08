using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailDistributing;
using MailDistributing.Contract;
using MailSending.Contract;

namespace MailSending
{
    public class MailSender : IMailSender
    {
        private readonly IMailDistributor _mailDistributor;

        public MailSender(IMailDistributor mailDistributor)
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
