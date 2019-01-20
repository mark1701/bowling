using NUnit.Framework;

namespace BowlingTests
{    
    public class Tests
    {
        [Test]
        public void DummyTest() {
            var gameScore = 300;
            var expectedScore = 300;

            Assert.AreEqual(expectedScore, gameScore);
        }
    }
}
