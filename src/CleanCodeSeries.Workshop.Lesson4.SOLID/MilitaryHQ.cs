/*
 * Randomly generated soldier go to war
 * They shoot at each other and get promotoed
 * Soldier->Leutenant->Commander
 * The moment a soldier reaches Commander rank, war is over.
 * And all soldiers dismiss.
 * Else, they shoot again.
 */
using System;

namespace CleanCodeSeries.Workshop.Lesson4.EasyOOP
{
    /// <summary>
    /// MilitaryHQ is just promoting soldiers.
    /// </summary>
    public class MilitaryHQ
    {
        private float XPForLeutenant = 100;
        private float XPForCommander = 1000;
        // Commander and leutenant make their choices differently. Thus they have
        // a different way of taking random choices.
        private IRandom _randomiserLeutenant;
        private IRandom _randomiserCommande;

        public MilitaryHQ(IRandom randomiserLeutenant, IRandom randomiserCommander)
        {
            _randomiserLeutenant = randomiserLeutenant;
            _randomiserCommande = randomiserCommander;
        }

        /// <summary>
        /// Promotes soldier to leutenant, leutenant to commander.
        /// </summary>
        public Soldier Promote(Soldier soldier)
        {
            if (soldier.XP >= XPForCommander && soldier is Leutenant)
            {
                soldier.XP -= XPForLeutenant;
                
                var commander = new Commander(soldier, _randomiserCommande);

                return commander;
            }
            else if (soldier.XP >= XPForLeutenant && soldier is Soldier)
            {
                soldier.XP -= XPForLeutenant;
                var leutenant = new Leutenant(soldier, _randomiserLeutenant);

                return leutenant;
            }

            return soldier;
        }
    }
}
