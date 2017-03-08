using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStoring;
using MailDistributing;
using MailPolling;
using MailSending;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var poller = new MailPoller();
            var sender = new MailSender();
            var repo = new ReceiverRepository();

            var distributor = new MailDistributor(poller, sender, repo);

            distributor.Start();

            Console.ReadKey();
        }
    }
}
