using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace TestComputerSciecneSearchIndeticalNumbers
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSearchIdenticalNumber()
        {
            int[] firstArray = new[] {4, 2, 1, 3, 2, 1};
            int[] secondArray = new[] {2, 3, 1, 2, 4, 1};
            List<int> arrayIdenticalNubers = new List<int> {4, 2, 1, 3};
            Assert.AreEqual(arrayIdenticalNubers, Program.GetSearchIdenticalNumbers(firstArray, secondArray, arrayIdenticalNubers);
        }
    }
}