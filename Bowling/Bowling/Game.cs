using System.Collections.Generic;

namespace Bowling
{
    public class Game
    {
        private readonly List<Frame> _frames;

        private Game(List<Roll> rolls)
        {
            for (int i = 0; i < rolls.Count-2; i+=2) {
                var frame = Frame.CreateFrameFromRolls(rolls[i], rolls[i + 1]);
                _frames.Add(frame);
            }
        }

        public static Game GetGameFromRolls(List<Roll> rolls)
        {
            return new Game(rolls);
        }
               
        public int CalculateScore()
        {
            return CalculateFramesScore();
        }

        private int CalculateFramesScore() {
            var score = 0;

            foreach (var frame in _frames) {
                score += frame.CalculateScore();
            }

            return score;
        }
    }
}
