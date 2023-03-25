namespace FactoryMethod.Business
{
    class Bmw : ICar
    {
        public string GetPriceByMode(string model)
        {
            if (model == "Z4")
            {
                return "800$";
            }
            else
            {
                return "Not avaliable right now!";
            }
        }
    }
}
