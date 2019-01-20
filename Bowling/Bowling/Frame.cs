namespace Bowling
{
    public interface IFrame {
        int CalculateScore();
    }

    public class Frame : IFrame
    {
        public int CalculateScore()
        {
            return 5;
        }
    }
}
