namespace Bowling.Model
{
    public interface IFrame
    {
        int CalculateScore();

        bool IsBonusRequired();
    }
}
