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
}
