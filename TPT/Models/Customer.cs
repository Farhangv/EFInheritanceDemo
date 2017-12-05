using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPT.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }

    }
}
