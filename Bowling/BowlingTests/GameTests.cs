using Bowling;
using NUnit.Framework;
using System.Collections.Generic;

namespace BowlingTests
{
    public class GameTests
    {
        private class GameTestsData
        {

            private readonly Roll onePinRoll = new Roll(1);
            private readonly Roll ninePinsRoll = new Roll(9);
            private readonly Roll tenPinsRoll = new Roll(10);
            private readonly Roll zeroPinsRoll = new Roll(0);

            public List<Roll> GetTestSequence()
            {
                return new List<Roll>()
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
