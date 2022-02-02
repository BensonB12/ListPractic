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
            var Ston = new HarrayPotter();
            // int Pages = 100;
            //int Pages = 
            Ston.NumberOfPages = 100;
            Assert.AreEqual(100, Ston.NumberOfPages);
            Ston.AddPages = 20;
            Assert.AreEqual(120, Ston.NumberOfPages);
        }

        [Test]
        public void testCoverpage()
        {
            var Ston = new HarrayPotter();
            Assert.AreEqual(false, Ston.CoverPage);
            Ston.CoverPage = true;
            Assert.AreEqual(true, Ston.CoverPage);
        }

    }
}