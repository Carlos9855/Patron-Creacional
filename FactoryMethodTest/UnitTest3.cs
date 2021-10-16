using FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryMethodTest
{
    [TestClass]
    public class UnitTest3
    {

        [TestMethod]
        public void TestMethodBass1()
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();
            IInstrument bass = factory.GetInstrument("Bass");
            string result = "This bass plays up to  : 86 notes";
            CollectionAssert.Equals(result, bass.Play(86));
        }

        [TestMethod]
        public void TestMethodBass2()
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();
            IInstrument bass = factory.GetInstrument("Bass");
            string result = "This bass has been sold for  : 450$";
            CollectionAssert.Equals(result, bass.Sell(450));
        }
        [TestMethod]
        public void TestMethodBass3()
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();
            IInstrument bass = factory.GetInstrument("Bass");
            string result = "This bass plays up to  : 86 notes";
            CollectionAssert.Equals(result, bass.Play(86));
            result = "This bass has been sold for  : 450$";
            CollectionAssert.Equals(result, bass.Sell(450));
        }
    }
}
