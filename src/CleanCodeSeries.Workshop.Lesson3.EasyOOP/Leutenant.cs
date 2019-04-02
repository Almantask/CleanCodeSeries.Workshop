/*
 * Randomly generated soldier go to war
 * They shoot at each other and get promotoed
 * Soldier->Leutenant->Commander
 * The moment a soldier reaches Commander rank, war is over.
 * And all soldiers dismiss.
 * Else, they shoot again.
 */
namespace CleanCodeSeries.Workshop.Lesson3.EasyOOP
{
    public class Leutenant:Soldier
    {
        public Leutenant(Soldier soldier) : base(soldier.Person, soldier.HP, soldier.XP) { }
    }
}
