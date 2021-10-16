using System;
namespace FactoryMethod
{
    public interface IInstrument
    {
        string Play(int notes);
        string Sell(int price);
    }
}
