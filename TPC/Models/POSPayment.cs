using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPC.Models
{
    public class POSPayment:Payment
    {
        public string POSBankName { get; set; }
        public string TrackingNumber { get; set; }
    }
}
