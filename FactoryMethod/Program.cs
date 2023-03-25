using FactoryMethod;
using FactoryMethod.Application;
using FactoryMethod.Business;

public class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Factory method ";

        ICarFactory carFactory = null;
        ICar car = null;
        string model = null;

        carFactory = new BenzFactory();
        car = carFactory.GetCar();

        model = Console.ReadLine();
        Console.WriteLine($"Car Model is : {model} and price {car.GetPriceByMode(model)}");
        Console.ReadKey();
    }
}