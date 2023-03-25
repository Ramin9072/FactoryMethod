using FactoryMethod.Business;

namespace FactoryMethod.Application
{
    public interface ICarFactory
    {
        ICar GetCar();
    }

}
