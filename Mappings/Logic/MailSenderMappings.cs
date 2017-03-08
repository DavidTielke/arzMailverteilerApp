using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSending;
using MailSending.Contract;
using Ninject.Modules;

namespace Mappings.Logic
{
    class MailSenderMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMailSender>().To<MailSender>();
        }
    }
}
