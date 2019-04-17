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
    public class War
    {
        public IList<Soldier> Reserve = new List<Soldier>();
        private Random _random = new Random();
        public ISoldierGenerator _generator;

        public War(ISoldierGenerator generator)
        {
            _generator = generator;
            Reserve = _generator.Generate();
            foreach(var soldier in Reserve)
            {
                soldier.ShotsFired += (sender2, e2) => LogShot(sender2, e2);
            }
        }

        private void LogShot(object sender, EventArgs e)
        {
            var shot = (ShotFiredEventArgs)e;
            LoggingService.Instance.Log($"{shot.ShooterName} shooting at {shot.TargetName}");
        }

        public void Simulate()
        {
            
            Fight(Reserve);
        }

        private void Fight(IList<Soldier> reserve)
        {
            var randomiserLeutenant = new Randomiser();
            var randomiserCommander = new Randomiser();
            var hq = new MilitaryHQ(randomiserLeutenant, randomiserCommander);
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
            } while (!Reserve.Any(s => s is Commander));

            EndWar(lastShooter);
        }

        private void EndWar(Soldier soldier)
        {
            Console.WriteLine($"War is over! {soldier.Name}");
        }


    }
}
