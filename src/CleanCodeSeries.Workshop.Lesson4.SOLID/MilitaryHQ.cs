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
    public class MilitaryHQ
    {
        private float XPForLeutenant = 100;
        private float XPForCommander = 1000;


        public Soldier Promote(Soldier soldier)
        {
            if (soldier.XP >= XPForCommander && soldier is Leutenant)
            {
                soldier.XP -= XPForLeutenant;
                var commander = new Commander(soldier);

                return commander;
            }
            else if (soldier.XP >= XPForLeutenant && soldier is Soldier)
            {
                soldier.XP -= XPForLeutenant;
                var leutenant = new Leutenant(soldier);

                return leutenant;
            }

            return soldier;
        }
    }
}
