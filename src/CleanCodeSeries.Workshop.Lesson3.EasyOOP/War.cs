using System;
using System.Collections.Generic;

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
    class War
    {
        private static Random _random;
        private static List<Soldier> reserver = new List<Soldier>();

        public static void Simulate()
        {


            // Generate random soldiers.
            var soldier1 = new Soldier("Tom", 24, 180, 80);
            var soldier2 = new Soldier("Tom", 24, 175, 68);
            var soldier3 = new Soldier("Tom", 24, 199.05f, 120.03f);
            var soldier4 = new Soldier("Tom", 21, 175, 110);
            var soldier5 = new Soldier("Tom", 24, 180, 80);
            var soldier6 = new Soldier("Tom", 24, 175, 68);
            var soldier7 = new Soldier("Tom", 24, 199.05f, 120.03f);
            var soldier8 = new Soldier("Tom", 21, 175, 110);

            reserver.Add(soldier1);
            reserver.Add(soldier2);
            reserver.Add(soldier3);
            reserver.Add(soldier4);
            reserver.Add(soldier5);
            reserver.Add(soldier6);
            reserver.Add(soldier7);
            reserver.Add(soldier8);

            // Shoot at randomly picked targets
            Shoot(soldier1, soldier1);
            Shoot(soldier2, soldier1);
            Shoot(soldier1, soldier5);
            Shoot(soldier8, soldier6);
            Shoot(soldier1, soldier4);
            Shoot(soldier5, soldier4);
            Shoot(soldier2, soldier3);
            Shoot(soldier1, soldier2);
            Shoot(soldier3, soldier1);
        }

        public static void Shoot(Soldier shooter, Soldier target)
        {
            const float chanceToHit = 50;
            var hit = _random.Next(100);
            if (hit > chanceToHit)
            {
                target.HP -= 50;
                if (target.HP <= 0)
                {
                    Console.WriteLine($"{target.Name}, {target.Age} years old met his destiny");
                    shooter.XP += 100;
                }
                else
                {
                    shooter.XP += 10;
                }
            }

            if (shooter.XP >= shooter.XPForPromotion)
            {
                shooter.XP -= shooter.XPForPromotion;

                if (shooter is Leutenant)
                {
                    shooter = new Commander()
                    {
                        Age = shooter.Age,
                        Height = shooter.Height,
                        Name = shooter.Name,
                        HP = shooter.HP,
                        Weight = shooter.Weight,
                        XP = shooter.XP,
                        XPForPromotion = 1000
                    };
                }
                else if (shooter is Soldier)
                {
                    shooter = new Leutenant()
                    {
                        Age = shooter.Age,
                        Height = shooter.Height,
                        Name = shooter.Name,
                        HP = shooter.HP,
                        Weight = shooter.Weight,
                        XP = shooter.XP,
                        XPForPromotion = 1000
                    };
                }
                
            }

            if (shooter is Commander)
            {
                Console.WriteLine("War is over!");
                // Clear reserve.
                reserver = new List<Soldier>();
            }
        }


    }

    public class Person { }


    public class Soldier: Person, ISoldier
    {
        public string Name;
        public int Age;
        public float Height;
        public float Weight;
        public float HP = 100;
        public float XP = 0;
        public float XPForPromotion = 100;
        
        public Soldier()
        {
            // Empty.
        }

        public Soldier(string tom, int i)
        {
            throw new NotImplementedException();
        }

        public Soldier(string tom, int i, float i1, float i2)
        {
            Name = tom;
            Age = i;
            Height = i1;
            Weight = i2;
        }

    }

    public class Leutenant : Soldier
    {
    }

    public class Commander : Leutenant
    {

    }

    internal interface ISoldier
    {

    }
}
