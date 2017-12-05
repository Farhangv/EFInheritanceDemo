using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPH.Models
{
    public class CardTransferPayment:Payment
    {
        public string LastDigits { get; set; }
        public string RefernceNumber { get; set; }

    }
}
