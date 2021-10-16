using System;
namespace FactoryMethod
{
    public class ConcreteInstrumentFactory: InstrumentFactory
    {
        public override IInstrument GetInstrument(string Instrument)
        {
            switch (Instrument)
            {
                case "Guitar":
                    return new Guitar();
                case "Piano":
                    return new Piano();
                case "Bass":
                    return new Bass();
                default:
                    throw new Exception(string.Format("Instrument '{0}' does not exist", Instrument));
            }
        }

    }
}
