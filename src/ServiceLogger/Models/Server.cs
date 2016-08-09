using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLogger.Models
{
    public class Server
    {
        [Key]
        public virtual int ID { get; set; }
        [Required, Index(IsUnique=true)]
        public virtual string Name { get; set; }
        public virtual DateTime DatePurchase { get; set; }
        [Required]
        public virtual string Model { get; set; }
        public virtual ICollection<LogEntry> Logs { get; set; }
    }
}
