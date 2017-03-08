using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStoring;
using MailPolling;
using MailSending;

namespace MailDistributing
{
    public class MailDistributor
    {
        private readonly MailPoller _poller;
        private readonly MailSender _sender;
        private readonly ReceiverRepository _repo;

        public MailDistributor()
        {
            _poller = new MailPoller(this);
            _sender = new MailSender(this);
            _repo = new ReceiverRepository();
        }

        public void Start()
        {
            Console.WriteLine("Mailverteiler gestartet...");
            _poller.Start();
        }

        public void Distribute()
        {
            Console.WriteLine("Mail wird verteilt");
            _repo.Load();
        }

        public void SentComplete()
        {
            Console.WriteLine("EMail wurde erfolgreich verteilt");
        }
    }
}
