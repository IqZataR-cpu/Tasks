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
        public void TestDefineMaxNumberSuccess()
        {
            int input = 9123213;

            Assert.AreEqual(9, Program.IsMaxNumber(input));
        }
        
        [Test]
        public void TestDefineMaxNumberFailed()
        {
            int input = 9123213;
            
            Assert.AreEqual(2, Program.IsMaxNumber(input));
        }
    }
}