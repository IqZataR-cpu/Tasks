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

            Assert.AreEqual(9, Program.GetMaxNumber(input));
        }
        
        [Test]
        public void TestDefineMaxNumberFailed()
        {
            int input = 9123213;
            
            Assert.AreEqual(2, Program.GetMaxNumber(input));
        }
    }
}