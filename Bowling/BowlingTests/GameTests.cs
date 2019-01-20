using Bowling;
using NUnit.Framework;
using System.Collections.Generic;

namespace BowlingTests
{
    public class GameTests
    {
        private class GameTestsData
        {

            private readonly AbstractRoll onePinRoll = new AbstractRoll(1);
            private readonly AbstractRoll ninePinsRoll = new AbstractRoll(9);
            private readonly AbstractRoll tenPinsRoll = new AbstractRoll(10);
            private readonly AbstractRoll zeroPinsRoll = new AbstractRoll(0);

            public List<AbstractRoll> GetTestSequence()
            {
                return new List<AbstractRoll>()
                {
                    //1
                    onePinRoll,
                    onePinRoll,
                    //2
                    onePinRoll,
                    ninePinsRoll,
                    //3
                    onePinRoll,
                    onePinRoll,
                    //4
                    tenPinsRoll,
                    zeroPinsRoll,
                    //5
                    onePinRoll,
                    onePinRoll,
                    //6
                    onePinRoll,
                    onePinRoll,
                    //7
                    onePinRoll,
                    onePinRoll,
                    //8
                    onePinRoll,
                    onePinRoll,
                    //9
                    onePinRoll,
                    onePinRoll,
                    //10
                    onePinRoll,
                    onePinRoll,
                    //11
                    onePinRoll,
                    onePinRoll,
                    //12
                    onePinRoll,
                    onePinRoll,
                };
            }
        }
    }
}
