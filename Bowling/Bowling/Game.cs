﻿namespace Bowling
{
    public class Game
    {
        private readonly Frame[] _frames;

        private Game() {
            _frames = new Frame[10];
            for (var i = 0; i < _frames.Length; i++)
            {
                _frames[i] = Frame.CreateNewFrame();
            }
        }

        private Game(Frame[] frames)
        {
            _frames = frames;
        }

        public static Game GetNewGame() {
            return new Game();
        }

        public static Game GetGameFromFrames(Frame[] frames)
        {
            return new Game(frames);
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
