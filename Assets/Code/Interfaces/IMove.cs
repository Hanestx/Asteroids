namespace Code.Patterns.Interfaces
{
    public interface IMove
    {
        float Speed { get; }
        void Move(float vertical);
    }
}