using System;
namespace FactoryMethod
{
    public class Piano : IInstrument
    {
        public string Play(int notes)
        {
            string result = "This piano plays up to  : " + notes.ToString() + " notes";
            return result;
        }

        public string Sell(int price)
        {
            string result = "This piano has been sold for  : " + price.ToString() + "$";
            return result;
        }
    }
}
