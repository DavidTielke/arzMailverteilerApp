using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStoring;
using DataStoring.Contract;
using MailDistributing.Contract;
using MailPolling;
using MailPolling.Contract;
using MailSending;
using MailSending.Contract;

namespace MailDistributing
{
    public class MailDistributor : IMailDistributor
    {
        private readonly IMailPoller _poller;
        private readonly IMailSender _sender;
        private readonly IReceiverRepository _repo;

        public MailDistributor(IMailPoller poller, IMailSender sender, IReceiverRepository repo)
        {
            _poller = poller;
            _sender = sender;
            _repo = repo;
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
