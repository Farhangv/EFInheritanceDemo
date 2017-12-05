using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPT.Models;

namespace TPT
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Payments = new List<Payment>() {
                    new POSPayment() { POSBankName = "Parsian",
                        TrackingNumber = "1234",
                        Amount = 2000,
                        CreatedDate = DateTime.Now }
                }
            };

            var ctx = new TPTDbContext();
            ctx.Customers.Add(customer);
            ctx.SaveChanges();
        }
    }
}
