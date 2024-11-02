using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrpoLabs.Core;

namespace TrpoLabs.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}
