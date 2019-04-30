namespace WorkshopPresentation.Bad7
{
    internal interface IHealer
    {
        void Heal(Soldier target, float amount);
        void Heal(float amount);
    }
}