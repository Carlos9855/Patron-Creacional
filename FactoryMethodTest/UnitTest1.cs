using FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryMethodTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethodGuitar1()
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();
            IInstrument guitar = factory.GetInstrument("Guitar");
            string result = "This guitar plays up to  : 96 notes";
            CollectionAssert.Equals(result, guitar.Play(96));
        }

        [TestMethod]
        public void TestMethodGuitar2()
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();
            IInstrument guitar = factory.GetInstrument("Guitar");
            string result = "This guitar has been sold for  : 120$";
            CollectionAssert.Equals(result, guitar.Sell(120));
        }
        [TestMethod]
        public void TestMethodGuitar3()
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();
            IInstrument guitar = factory.GetInstrument("Guitar");
            string result = "This guitar plays up to  : 96 notes";
            CollectionAssert.Equals(result, guitar.Play(96));
            result = "This guitar has been sold for  : 120$";
            CollectionAssert.Equals(result, guitar.Sell(120));
        }
    }
}
