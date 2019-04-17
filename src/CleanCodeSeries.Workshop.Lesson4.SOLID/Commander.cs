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
    /// Highest ranking soldier.
    /// </summary>
    public class Commander:Soldier
    {
        public Commander(Soldier soldier, IRandom random) : base(soldier, soldier.HP, soldier.XP, random) { }
    }
}
