using FactoryMethod.Business;

namespace FactoryMethod.Application
{
    public class BmwFactory : ICarFactory
    {
        public ICar GetCar()
        {
            return new Bmw();
        }
    }

}
