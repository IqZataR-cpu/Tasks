using ComputerScienceConditionYears;
using NUnit.Framework;


// Мои слова о том, как правильно писать методы тестов остались где то в стороне...
// TestMethod_Should_When вот такая структура написания тестов, примеры ищи в беседе.
namespace ComputerScienceConditionYear
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstTestValidLeapYear()
        {
            int firstYear = 2020;

            Assert.AreEqual("Високосный год", ValidLeapYear.LeepYear(firstYear));
        }
        
        [Test]
        public void SecondTestValidLeapYear()
        {
            int secondYear = 2018;
            
            Assert.AreEqual("Обычный год", ValidLeapYear.LeepYear(secondYear));
        }
    }
}
