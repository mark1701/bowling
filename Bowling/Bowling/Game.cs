using System;

namespace Bowling
{
    public interface IGame {
        int CalculateScore();
    }
    public class Game : IGame
    {
        public int CalculateScore()
        {
            return CalculateFramesScore();
        }

        private int CalculateFramesScore() {
            return 150;
        }
    }
}
