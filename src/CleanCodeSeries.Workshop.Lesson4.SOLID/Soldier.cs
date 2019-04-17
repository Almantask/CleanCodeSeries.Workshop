using CleanCodeSeries.Workshop.Lesson4.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Randomly generated soldier go to war
 * They shoot at each other and get promotoed
 * Soldier->Leutenant->Commander
 * The moment a soldier reaches Commander rank, war is over.
 * And all soldiers dismiss.
 * Else, they shoot again.
 */
namespace CleanCodeSeries.Workshop.Lesson4.EasyOOP
{
    public class Soldier
    {
        protected Person Person { get; }
        public float HP { get; set; }
        public float XP {get;set;}
        public event EventHandler ShotsFired;

        public string Name => Person.Name;
        public int Age => Person.Age;
        public float Weight => Person.Weight;
        public float Height => Person.Height;

        private int _consequitiveShots;

        private IRandom _random;

        public Soldier(Person person, float hp, float xp, IRandom random)
        {
            Person = person;
            HP = hp;
            XP = xp;
            _random = random;
        }

        public Soldier(Soldier soldier, float hp, float xp, IRandom random)
        {
            Person = soldier.Person;
            HP = hp;
            XP = xp;
            _random = random;
        }

        public void Shoot(IList<Soldier> soldiers)
        {
            var isDead = HP <= 0;
            if (isDead) return;

            Soldier target = PickRandomTarget(soldiers);
            ShotsFired?.Invoke(this, new ShotFiredEventArgs(Name, target.Name));

            var hitRoll = _random.Next(100);
            if (IsTargetHit(hitRoll))
            {
                _consequitiveShots++;
                DealDamage(target);
            }
            else
            {
                _consequitiveShots = 0;
            }
        }

        private void DealDamage(Soldier target)
        {
            const float damage = 50;
            var multiplier = GetDamageMultiplier();

            var totalDamage = damage * multiplier;
            Console.WriteLine($"Damage: {totalDamage}");
            target.HP -= totalDamage;

            var isTargetDead = target.HP <= 0;
            if (isTargetDead)
            {
                target.Die();
                const int rewardForKill = 100;
                XP += rewardForKill;
            }
            else
            {
                const int rewardForHit = 10;
                XP += rewardForHit;
            }
        }

        private int GetDamageMultiplier()
        {
            const int minComboShots = 1;
            int damageMultiplier = 1;
            if (_consequitiveShots > minComboShots)
            {
                damageMultiplier = 2;
            }

            return damageMultiplier;
        }

        private void Die()
        {
            Console.WriteLine($"{Name}, {Age} years old met his destiny");
        }

        private Soldier PickRandomTarget(IList<Soldier> soldiers)
        {
            var max = soldiers.Count() - 1;
            var index = _random.Next(max);
            var target = soldiers[index];
            return target;
        }

        private bool IsTargetHit(int hitRoll)
        {
            const float chanceToHit = 50;
            return hitRoll > chanceToHit;
        }

    }
}
