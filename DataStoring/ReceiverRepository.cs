using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStoring.Contract;

namespace DataStoring
{
    public class ReceiverRepository : IReceiverRepository
    {
        public void Load()
        {
            Console.WriteLine("Empfänger wurden geladen");
        }
    }
}
