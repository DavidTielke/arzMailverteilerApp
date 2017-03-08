using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailDistributing;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var distributor = new MailDistributor();

            distributor.Start();

            Console.ReadKey();
        }
    }
}
