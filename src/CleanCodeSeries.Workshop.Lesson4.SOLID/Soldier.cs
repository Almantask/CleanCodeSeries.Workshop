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
    /// <summary>
    /// Soldier violates SRP still. It has more reasons to change than it should:
    /// Soldier fights (shoots). If randomisation or combat changes, soldier class will need to change.
    /// Twe two should be separate components.
    /// </summary>
    public class Soldier
    {
        /// <summary>
        /// Person is not a parent, because we might have a robo soldier or mutant soldier, etc. 
        /// Also because it's preferable to have fewer chains of dependencies and inheritance creates such chain.
        /// </summary>
        protected Person Person { get; }
        public float HP { get; set; }
        public float XP {get;set;}
        /// <summary>
        /// We decoupled logging from shooting. For that we used ShotsFired event.
        /// </summary>
        public event EventHandler ShotsFired;

        // Just like compoistion, we use protected/private (NOT public)
        // and call what we need from that component to the public.
        // In this case we need properties, so we return properties from protected person.
        // Person can contain a name, but we can easilly change that if needed.
        public string Name => Person.Name;
        public int Age => Person.Age;
        public float Weight => Person.Weight;
        public float Height => Person.Height;

        private int _consequitiveShots;

        /// <summary>
        /// Randomiser. In order to test random behaviour, we need to be in control.
        /// Chaotic randomisation is being out of control. So we use abstraction, to be
        /// able to inject implementation of completely controllable random numbers generator.
        /// </summary>
        private IRandom _random;

        public Soldier(Person person, float hp, float xp, IRandom random)
        {
            Person = person;
            HP = hp;
            XP = xp;
            _random = random;
        }

        /// <summary>
        /// When soldier gets promoted, previous state of old soldier gets 
        /// transfered to a new soldier. Thus the soldier in constructor.
        /// </summary>
        public Soldier(Soldier soldier, float hp, float xp, IRandom random)
        {
            Person = soldier.Person;
            HP = hp;
            XP = xp;
            _random = random;
        }

        public void Shoot(IList<Soldier> soldiers)
        {
            // 0 is not a magic number, refers to empty, nothing, default, dead, etc..
            var isDead = HP <= 0;
            if (isDead) return;

            Soldier target = PickRandomTarget(soldiers);
            // Logging has been decoupled.
            // Usign event instead, which is still part of shooting (still doing one thing).
            ShotsFired?.Invoke(this, new ShotFiredEventArgs(Name, target.Name));

            // 100 is not a magic number, usually refers to 100%.
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
            // Magic nubmer, thus using named constant.
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
