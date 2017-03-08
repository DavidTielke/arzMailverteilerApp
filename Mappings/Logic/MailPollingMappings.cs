using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailPolling;
using MailPolling.Contract;
using Ninject.Modules;

namespace Mappings.Logic
{
    class MailPollingMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailPoller>().To<MailPoller>();
        }
    }
}
