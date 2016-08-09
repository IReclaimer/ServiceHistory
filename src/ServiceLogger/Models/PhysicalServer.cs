using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLogger.Models
{
    public class PhysicalServer
    {
        public virtual ICollection<VirtualMachine> VirtualMachines { get; set; }
    }
}
