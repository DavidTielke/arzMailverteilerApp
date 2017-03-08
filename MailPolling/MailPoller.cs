using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailDistributing;
using MailDistributing.Contract;
using MailPolling.Contract;

namespace MailPolling
{
    public class MailPoller : IMailPoller
    {
        private readonly IMailDistributor _mailDistributor;

        public MailPoller(IMailDistributor mailDistributor)
        {
            _mailDistributor = mailDistributor;
        }

        public void Start()
        {
            Console.WriteLine("Poller gestartet");
            ErkenneMail();
        }

        private void ErkenneMail()
        {
            Console.WriteLine("Mail erkannt");
            Console.WriteLine("Mail wurde heruntergeladen");
            _mailDistributor.Distribute();
        }
    }
}
