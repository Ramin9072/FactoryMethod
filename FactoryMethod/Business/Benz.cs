namespace FactoryMethod.Business
{
    class Benz : ICar
    {
        public string GetPriceByMode(string model)
        {
            if (model.ToUpper() == "E200")
            {
                return "1000$";
            }
            else
            {
                return "Not avaliable right now!";
            }
        }
    }
}
