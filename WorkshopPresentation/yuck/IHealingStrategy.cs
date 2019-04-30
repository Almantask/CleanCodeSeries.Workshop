namespace WorkshopPresentation.Bad7
{
    internal interface IHealingStrategy
    {
        void Use(float amount);
        void Use(Soldier soldier, float amount);
    }
}