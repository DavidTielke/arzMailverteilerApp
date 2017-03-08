using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailDistributing;
using MailDistributing.Contract;
using Ninject.Modules;

namespace Mappings.Logic
{
    class MailDistributingMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailDistributor>().To<MailDistributor>();
        }
    }
}
