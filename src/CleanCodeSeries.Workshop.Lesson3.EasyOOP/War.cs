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
    public class War
    {
        private IList<Soldier> _reserve = new List<Soldier>();
        private Random _random = new Random();
        public void Simulate()
        {
            _reserve = GenerateSoldiers();
            Fight(_reserve);
        }

        private IList<Soldier> GenerateSoldiers()
        {
            var soldiers = new List<Soldier>();


            var person1 = new Person("Tom", 24, 180, 80);
            var person2 = new Person("Jack", 24, 175, 68);
            var person3 = new Person("Tim", 24, 199.05f, 120.03f);
            var person4 = new Person("Tom1", 21, 175, 110);
            var person5 = new Person("Tom2", 24, 180, 80);
            var person6 = new Person("Tom3", 24, 175, 68);
            var person7 = new Person("Tom4", 24, 199.05f, 120.03f);
            var person8 = new Person("Tom5", 21, 175, 110);

            var soldier1 = new Soldier(person1, 100, 10);
            var soldier2 = new Soldier(person2, 100, 10);
            var soldier3 = new Soldier(person3, 100, 10);
            var soldier4 = new Soldier(person4, 100, 10);
            var soldier5 = new Soldier(person5, 100, 10);
            var soldier6 = new Soldier(person6, 100, 10);
            var soldier7 = new Soldier(person7, 100, 10);
            var soldier8 = new Soldier(person8, 100, 10);

            soldiers.Add(soldier1);
            soldiers.Add(soldier2);
            soldiers.Add(soldier3);
            soldiers.Add(soldier4);
            soldiers.Add(soldier5);
            soldiers.Add(soldier6);
            soldiers.Add(soldier7);
            soldiers.Add(soldier8);

            return soldiers;
        }

        private void Fight(IList<Soldier> reserve)
        {
            var hq = new MilitaryHQ();
            Soldier lastShooter;
            do
            {
                var max = reserve.Count-1;
                var shooterIndex = _random.Next(max);
                var soldier = reserve[shooterIndex];

                var possibleTargets = reserve.Where(x => x != soldier && x.HP > 0);
                lastShooter = soldier;
                if (!possibleTargets.Any()) break;

                soldier.Shoot(possibleTargets.ToList());
                var promoted = hq.Promote(soldier);
                reserve[shooterIndex] = promoted;
                lastShooter = promoted;
            } while (!_reserve.Any(s => s is Commander));

            EndWar(lastShooter);
        }

        private void EndWar(Soldier soldier)
        {
            Console.WriteLine($"War is over! {soldier.Person.Name}");
        }


    }

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
                TakeDamage(target);
            }
        }

        private void TakeDamage(Soldier target)
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

    public class Person
    {
        public string Name { get; }
        public int Age { get; }
        public float Weight { set; get; }
        public float Height { set; get; }

        public Person(string name, int age, float weight, float height)
        {
            Name = name;
            Age = age;
            Height = weight;
            Weight = height;
        }
    }


    public class Leutenant:Soldier
    {
        public Leutenant(Soldier soldier) : base(soldier.Person, soldier.HP, soldier.XP) { }
    }

    public class Commander:Soldier
    {
        public Commander(Soldier soldier) : base(soldier.Person, soldier.HP, soldier.XP) { }
    }

    internal interface ISoldier
    {

    }
}
