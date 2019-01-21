using Bowling;
using NUnit.Framework;
using System.Collections.Generic;

namespace BowlingTests
{
    public class GameTests
    {


        public void CreateGame(List<string> rolls) {

        }



        private class GameTestsData
        {
            public List<string> GetTestSequence()
            {
                return new List<string>()
                {
                    //1
                    "1",
                    "1",
                    //2
                    "1",
                    "9",
                    //3
                    "1",
                    "1",
                    //4
                    "10",
                    "X",
                    //5
                    "1",
                    "1",
                    //6
                    "1",
                    "1",
                    //7
                    "1",
                    "1",
                    //8
                    "1",
                    "1",
                    //9
                    "1",
                    "1",
                    //10
                    "1",
                    "1",
                    //11
                    "1",
                    "1",
                    //12
                    "1",
                    "1",
                };
            }
        }
    }
}
