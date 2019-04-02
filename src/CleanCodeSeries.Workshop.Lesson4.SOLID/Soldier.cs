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
namespace CleanCodeSeries.Workshop.Lesson3.EasyOOP
{
    public class Soldier
    {
        public Person Person;
        public float HP { get; set; }
        public float XP {get;set;}

        private Random _random;

        public Soldier(Person person, float hp, float xp)
        {
            Person = person;
            HP = hp;
            XP = xp;
            _random = new Random();
        }

        public void Shoot(IList<Soldier> soldiers)
        {
            var isDead = HP <= 0;
            if (isDead) return;

            Soldier target = PickRandomTarget(soldiers);
            Console.WriteLine($"{Person.Name} shooting at {target.Person.Name}");
            if (IsTargetHit())
            {
                DealDamage(target);
            }
        }

        private void DealDamage(Soldier target)
        {
            const float damage = 50;
            target.HP -= damage;
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

        private void Die()
        {
            Console.WriteLine($"{Person.Name}, {Person.Age} years old met his destiny");
        }

        private Soldier PickRandomTarget(IList<Soldier> soldiers)
        {
            var max = soldiers.Count() - 1;
            var index = _random.Next(max);
            var target = soldiers[index];
            return target;
        }

        private bool IsTargetHit()
        {
            const float chanceToHit = 50;
            var hit = _random.Next(100);

            return hit > chanceToHit;
        }

    }
}
