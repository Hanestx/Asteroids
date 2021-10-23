namespace Code.Patterns.BehavioralPatterns.State
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }

}