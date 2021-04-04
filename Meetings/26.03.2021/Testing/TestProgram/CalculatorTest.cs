using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Testing;

namespace TestProgram
{
    public class Tests
    {
        private Calculator _calculator;
        
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void TestSuccessAdd()
        {
            int x = 2;
            int y = 3;

            Assert.AreEqual(5, _calculator.Add(x, y));
        }
    }
}