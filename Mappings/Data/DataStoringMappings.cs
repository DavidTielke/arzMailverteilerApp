using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStoring;
using DataStoring.Contract;
using Ninject.Modules;

namespace Mappings.Data
{
    class DataStoringMappings : NinjectModule
    {
        public override void Load()
        {
            Bind<IReceiverRepository>().To<ReceiverRepository>();
        }
    }
}
