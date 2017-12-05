using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPH.Models;

namespace TPH
{
    class Program
    {
        static void Main(string[] args)
        {
            TPHDbContext ctx = new TPHDbContext();
            //var cardPayments = ctx.Payments.OfType<CardTransferPayment>();
            var cardPayments = ctx.CardTransferPayments;
            foreach (var payment in cardPayments)
            {
                Console.WriteLine(payment);
            }
            Console.ReadKey();

            //CardTransferPayment ctp = new CardTransferPayment()
            //{
            //    Amount = 10000,
            //    CreatedDate = DateTime.Now,
            //    CustomerName = "Farhang Vafa",
            //    LastDigits = "1234",
            //    RefernceNumber = "123456789"
            //};

            ////ctx.CardTransferPayments.Add(ctp);
            //ctx.Payments.Add(ctp);
            //ctx.SaveChanges();
        }
    }
}
