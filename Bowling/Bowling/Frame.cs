namespace Bowling
{
    public interface IFrame {
        int CalculateScore();
    }

    public abstract class Frame : IFrame
    {
        public int CalculateScore()
        {
            throw new System.NotImplementedException();
        }
    }
}
