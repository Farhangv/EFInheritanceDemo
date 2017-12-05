using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPT.Models
{
    public abstract class Payment
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
