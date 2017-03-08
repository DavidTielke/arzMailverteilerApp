using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappings.Data;
using Mappings.Logic;
using Ninject.Modules;

namespace Mappings
{
    public class Aggregator
    {
        public INinjectModule[] Mappings => new INinjectModule[]
        {
            new MailPollingMappings(), 
            new MailSenderMappings(), 
            new MailDistributingMappings(), 
            new DataStoringMappings(), 
        };
    }
}
