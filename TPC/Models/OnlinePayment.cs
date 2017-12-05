using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC.Models
{
    public class OnlinePayment:Payment
    {
        public string GatewayName { get; set; }
        public string DigitalReciept { get; set; }
        public string TransactionNumber { get; set; }
        public string Status { get; set; }
    }
}
