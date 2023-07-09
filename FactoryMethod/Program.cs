using FactoryMethod;
using FactoryMethod.Model;

public class Program
{
    private static void Main(string[] args)
    {
        // simple factory
        //var payment = Payment.ForChargingWallet();
        //var payment1 = Payment.ForPayingOrder();

        var currentProduct = new Product.Builder()
             .ProductName("Microphone")
             .RetailPrice(200M)
             .Create();

        var currentProduct2 = new Product.Builder()
              .ProductName("Microphone")
              .Create();

        Console.WriteLine(currentProduct.ProductName);

        var order = new Order(1000);
        Payment.ForPayingOrder(order);


    }
}