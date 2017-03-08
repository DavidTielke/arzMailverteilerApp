using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStoring;
using MailDistributing;
using MailDistributing.Contract;
using MailPolling;
using MailSending;
using Mappings;
using Ninject;

namespace ConsoleClient
{
    class Program
    {
        private static IMailDistributor _distributor;

        static Program()
        {
            var kernel = new StandardKernel(new Aggregator().Mappings);
            _distributor = kernel.Get<IMailDistributor>();
        }

        static void Main(string[] args)
        {
            _distributor.Start();

            Console.ReadKey();
        }
    }
}
