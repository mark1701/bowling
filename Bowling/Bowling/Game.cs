using Bowling.Model;
using System.Collections.Generic;

namespace Bowling
{
    public class Game
    {
        private List<IFrame> _frames;

        public Game(List<string> rollsData) {
            _frames = new List<IFrame>();

            GenerateFrames(rollsData);
        }

        public int CalculateScore() {
            return 8;
        }

        private void GenerateFrames(List<string> rollsData)
        {
            for (int i = 0; i < rollsData.Count - 2; i += 2)
            {
                var firstRollData = rollsData[i];
                var secondRollData = rollsData[i + 1];

                var rolls = new List<Roll> { new Roll(int.Parse(firstRollData)) };

                if (secondRollData != "X")
                {
                    rolls.Add(new Roll(int.Parse(secondRollData)));
                }
                var frame = FrameFactory.CreateFrame(rolls);

                _frames.Add(frame);
            }
        }

        public bool HasFrames() => _frames.Count > 0;
    }
}
