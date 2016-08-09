using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLogger.Models
{
    public class LogEntry
    {
        [Key]
        public virtual int ID { get; set; }
        public virtual DateTime DateLog { get; set; }
        public virtual List<Server> Servers { get; set; }
        [Required]
        public virtual string Log { get; set; }

    }
}
