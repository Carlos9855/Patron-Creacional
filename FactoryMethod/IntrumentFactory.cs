using System;
namespace FactoryMethod
{
    public abstract class InstrumentFactory
    {
        public abstract IInstrument GetInstrument(string Instrument);

    }
}
