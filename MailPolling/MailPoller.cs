using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailPolling
{
    public class MailPoller : IMailPoller
    {
        private readonly MailDistributor _mailDistributor;

        public MailPoller(MailDistributor mailDistributor)
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
