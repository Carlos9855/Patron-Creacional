using FactoryMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryMethodTest
{
    [TestClass]
    public class UnitTest2
    {

        [TestMethod]
        public void TestMethodPiano1()
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();
            IInstrument piano = factory.GetInstrument("Piano");
            string result = "This piano plays up to  : 130 notes";
            CollectionAssert.Equals(result, piano.Play(130));
        }

        [TestMethod]
        public void TestMethodPiano2()
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();
            IInstrument piano = factory.GetInstrument("Piano");
            string result = "This piano has been sold for  : 1200$";
            CollectionAssert.Equals(result, piano.Sell(1200));
        }
        [TestMethod]
        public void TestMethodPiano3()
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();
            IInstrument piano = factory.GetInstrument("Piano");
            string result = "This piano plays up to  : 130 notes";
            CollectionAssert.Equals(result, piano.Play(130));
            result = "This piano has been sold for  : 1200$";
            CollectionAssert.Equals(result, piano.Sell(1200));
        }
    }
}
