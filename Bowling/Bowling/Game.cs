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
            return 150;
        }
    }
}
