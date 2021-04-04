using ComputerSciencePointBelogngsToACircle;
using NUnit.Framework;

namespace TestPointBelongs
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test] public void IsPointBelongsToACircle_ShouldReturnTrue()
        {
            int x = 2;
            int y = 3;
            int radiusCircle = 6;
          
            Assert.AreEqual(true, Program.IsPointBelongsToACircle(x, y, radiusCircle));
        }
    }
}