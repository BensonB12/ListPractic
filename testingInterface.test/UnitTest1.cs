using interfacePractice;
using NUnit.Framework;

namespace testingInterface.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void testingHaryPoter()
        {
            var Ston = new HarrayPotter(100);
        }
        [Test]
        public void testingHaryPoterPages()
        {
            var Ston = new HarrayPotter(100);
            // int Pages = 100;
            int Pages = Ston.GetNumberOfPages();
            Assert.AreEqual(100, Pages);
        }
    }
}