using System;
using ComputerScienceCyclesDefineMaxNumber;
using NUnit.Framework;

namespace TestDefineMaxNumber
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDefineMaxNumber()
        {
            int input = 9123213;
            int count = Convert.ToString(input).Length;
            
            Assert.AreEqual(9, Program.IsMaxNumber(input, count));
        }
    }
}