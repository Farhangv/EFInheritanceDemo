using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPT.Models
{
    //[Table("CardTransferPayment", Schema = "Payments")]
    public class CardTransferPayment:Payment
    {
        public string LastDigits { get; set; }
        public string RefernceNumber { get; set; }

    }
}
