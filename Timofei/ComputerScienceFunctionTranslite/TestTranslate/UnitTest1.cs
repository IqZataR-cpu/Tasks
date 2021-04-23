using System;
using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace TestTranslate
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPrintUserTranslate()
        {
            string data = "привет";
            
            Assert.AreEqual("privet", );
            //Assert.AreEqual("privet",);
        }
        
    }
}