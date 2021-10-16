using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();

            IInstrument guitar = factory.GetInstrument("Guitar");
            string a= guitar.Play(96);
            string b = guitar.Sell(120);
            Console.WriteLine(a);
            Console.WriteLine(b);

            IInstrument piano = factory.GetInstrument("Piano");
            a=piano.Play(80);
            b=piano.Sell(1000);
            Console.WriteLine(a);
            Console.WriteLine(b);

            IInstrument bass = factory.GetInstrument("Bass");
            a=bass.Play(75);
            b=bass.Sell(150);
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
