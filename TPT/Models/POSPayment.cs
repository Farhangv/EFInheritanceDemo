using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPT.Models
{
    //[Table("POSPayment", Schema = "Payments")]
    public class POSPayment:Payment
    {
        public string POSBankName { get; set; }
        public string TrackingNumber { get; set; }
    }
}
