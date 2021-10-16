using System;
namespace FactoryMethod
{
    public class Guitar: IInstrument
    {
        public string Play(int notes){
            string result = "This guitar plays up to  : " + notes.ToString() + " notes";
            return result;
        }

        public string Sell(int price){
            string result = "This guitar has been sold for  : " + price.ToString() + "$";
            return result;
        }
    }
}
