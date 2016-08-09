using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLogger.Models
{
    public class VirtualMachine : Server
    {
        public virtual Server Hypervisor { get; set; }
    }
}
