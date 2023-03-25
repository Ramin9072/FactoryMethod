using FactoryMethod;
using FactoryMethod.Model;

public class Program
{
    private static void Main(string[] args)
    {
        // simple factory
        //var payment = Payment.ForChargingWallet();
        //var payment1 = Payment.ForPayingOrder();

        var order = new Order(1000);
        Payment.ForPayingOrder(order);


    }
}