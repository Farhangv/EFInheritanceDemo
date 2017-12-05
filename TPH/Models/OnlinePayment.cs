using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPH.Models
{
    public class OnlinePayment:Payment
    {
        public string GatewayName { get; set; }
        public string DigitalReciept { get; set; }
        public string TransactionNumber { get; set; }
        public string Status { get; set; }
    }
}
