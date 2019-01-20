namespace Bowling
{
    public class Frame
    {
        private readonly Roll _firstRoll;
        private readonly Roll _secondRoll;

        private Frame (Roll firstRoll, Roll secondRoll) {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public static Frame CreateNewFrame() {
            var firstRoll = new Roll(0);
            var secondRoll = new Roll(0);

            return new Frame(firstRoll, secondRoll);
        }

        public static Frame CreateFrameFromRolls(Roll firstRoll, Roll secondRoll) {
            return new Frame(firstRoll, secondRoll);
        }

        public int CalculateScore()
        {
            return _firstRoll.GetScore() + _secondRoll.GetScore();
        }
    }
}
