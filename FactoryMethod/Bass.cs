using System;
namespace FactoryMethod
{
    public class Bass : IInstrument
    {
        public string Play(int notes)
        {
            string result = "This bass plays up to  : " + notes.ToString() + " notes";
            return result;
        }

        public string Sell(int price)
        {
            string result = "This bass has been sold for  : " + price.ToString() + "$";
            return result;
        }
    }
}
