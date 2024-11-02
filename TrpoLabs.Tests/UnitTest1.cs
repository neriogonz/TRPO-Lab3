using NUnit.Framework;
using TrpoLabs.Core;

namespace TrpoLabs.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAddMethod()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
