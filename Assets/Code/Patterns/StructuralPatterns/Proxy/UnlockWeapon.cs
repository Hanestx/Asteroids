namespace Code.Patterns.StructuralPatterns.Proxy
{
    public sealed class UnlockWeapon
    {
        public bool IsUnlock { get; set; }
    
        public UnlockWeapon(bool isUnlock)
        {
            IsUnlock = isUnlock;
        }
    }
}