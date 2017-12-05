using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPH.Models
{
    public abstract class Payment
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedDate { get; set; }

        public override string ToString()
        {
            return $"{this.CustomerName} {this.Amount}";
        }
    }
}
