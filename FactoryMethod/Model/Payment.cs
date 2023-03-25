using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Model
{
    public class Payment
    {
        //public Payment(long amount)
        //{
        //    Id = new Guid();
        //    Amount = amount;
        //}

        //public Payment(Order order)
        //{
        //    Amount = order.TotalPrice;
        //}

        private Payment(long amount)
        {
            Id = new Guid();
            Amount = amount;
        }
        public static Payment ForPayingOrder(Order order) {
            return new Payment(order.TotalPrice);
        }
         public static Payment ForChargingWallet(long amount)
        {
            return new Payment(amount);
        }

        public Guid Id { get; init; }
        public long Amount { get; init; }

    }

    public class Order
    {
        public Order(long totalPrice)
        {
            TotalPrice = totalPrice;
        }

        public long TotalPrice { get; set; }
    }
}
