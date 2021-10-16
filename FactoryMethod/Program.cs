using System;

namespace FactoryMethod
{
    static class Program
    {
        static void Main(string[] args)
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();
            string play;
            string sell;
            IInstrument guitar = factory.GetInstrument("Guitar");
            play= guitar.Play(96);
            sell = guitar.Sell(120);
            Console.WriteLine(play);
            Console.WriteLine(sell);

            IInstrument piano = factory.GetInstrument("Piano");
            play = piano.Play(80);
            sell = piano.Sell(1000);
            Console.WriteLine(play);
            Console.WriteLine(sell);

            IInstrument bass = factory.GetInstrument("Bass");
            play = bass.Play(75);
            sell = bass.Sell(150);
            Console.WriteLine(play);
            Console.WriteLine(sell);


        }
    }
}
