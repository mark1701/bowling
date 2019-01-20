using Bowling;
using NUnit.Framework;

namespace BowlingTests
{
    public class FrameTests
    {
        [Test]
        public void EmptyFrameHasZeroScore() {
            var frame = Frame.CreateEmptyFrame();
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(0, calculatedValue);
        }

        [Test]
        public void ScoreIsTheSumOfTwoRolls()
        {
            var firstRoll = new Roll(4);
            var secondRoll = new Roll(12);
            var expectedResult = 16;

            var frame = Frame.CreateFrameFromRolls(firstRoll, secondRoll);
            var calculatedValue = frame.CalculateScore();

            Assert.AreEqual(expectedResult, calculatedValue);
        }

        [Test]
        public void AllPinsDownInTwoRollsRequireBonusPoints() {
            var firstRoll = new Roll(4);
            var secondRoll = new Roll(6);
            var frame = Frame.CreateFrameFromRolls(firstRoll, secondRoll);

            Assert.IsTrue(frame.IsBonusRequired());
        }

        [Test]
        public void AllPinsDownOnTheFirstRollRequireBonusPoints()
        {
            var firstRoll = new Roll(10);
            var secondRoll = new Roll(0);
            var frame = Frame.CreateFrameFromRolls(firstRoll, secondRoll);

            Assert.IsTrue(frame.IsBonusRequired());
        }
    }
}
