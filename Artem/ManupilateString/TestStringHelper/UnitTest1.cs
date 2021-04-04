using ManupilateString;
using NUnit.Framework;
using System;
using System.IO;

namespace TestStringHelper
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestReverseSuccess()
        {
            string result = "";
            string expected = "gnirts";
            StringHelper stringHelper = new StringHelper("string");

            stringHelper.Reverse();

            var sw = new StringWriter();
            Console.SetOut(sw);
            stringHelper.Print();
            result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestReverseDenied()
        {
            string result = "";
            string expected = "string";
            StringHelper stringHelper = new StringHelper("string");

            stringHelper.Reverse();

            var sw = new StringWriter();
            Console.SetOut(sw);
            stringHelper.Print();
            result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestUcFirstSuccess()
        {
            string result = "";
            string expected = "String";
            StringHelper stringHelper = new StringHelper("string");

            stringHelper.ucFirst();

            var sw = new StringWriter();
            Console.SetOut(sw);
            stringHelper.Print();
            result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);          
        }

        [Test]
        public void TestUcFirstDenied()
        {
            string result = "";
            string expected = "sTring";
            StringHelper stringHelper = new StringHelper("string");

            stringHelper.ucFirst();

            var sw = new StringWriter();
            Console.SetOut(sw);
            stringHelper.Print();
            result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestUcWordSuccess()
        {
            string result = "";
            string expected = "String String String String";
            StringHelper stringHelper = new StringHelper("string string string string");

            stringHelper.ucWord();

            var sw = new StringWriter();
            Console.SetOut(sw);
            stringHelper.Print();
            result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestUcWordDenied()
        {
            string result = "";
            string expected = "sTring sTring sTring sTring";
            StringHelper stringHelper = new StringHelper("string");

            stringHelper.ucWord();

            var sw = new StringWriter();
            Console.SetOut(sw);
            stringHelper.Print();
            result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
        }
    }
}