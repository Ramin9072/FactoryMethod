using FactoryMethod.Business;

namespace FactoryMethod.Application
{
    public class BenzFactory : ICarFactory
    {
        public ICar GetCar()
        {
            return new Benz();
        }
    }

}
