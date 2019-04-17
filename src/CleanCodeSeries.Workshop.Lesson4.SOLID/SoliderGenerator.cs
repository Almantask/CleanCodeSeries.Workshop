using CleanCodeSeries.Workshop.Lesson4.EasyOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID
{
    public class SoldierGenerator:ISoldierGenerator
    {
        public IList<Soldier> Generate()
        {
            var soldiers = new List<Soldier>();

            var person1 = new Person("Tom", 24, 180, 80);
            var person2 = new Person("Jack", 24, 175, 68);
            var person3 = new Person("Tim", 24, 199.05f, 120.03f);
            var person4 = new Person("Tom1", 21, 175, 110);
            var person5 = new Person("Tom2", 24, 180, 80);
            var person6 = new Person("Tom3", 24, 175, 68);
            var person7 = new Person("Tom4", 24, 199.05f, 120.03f);

            var randomOriginal = new Randomiser();
            var randomviaHalf = new RandomiserHalfed();
            var randomviaZero = new RandomiserZero();
            var soldier1 = new Soldier(person1, 100, 10, randomOriginal);
            var soldier2 = new Soldier(person2, 100, 10, randomOriginal);
            var soldier3 = new Soldier(person3, 100, 10, randomviaHalf);
            var soldier4 = new Soldier(person4, 100, 10, randomviaZero);
            var soldier5 = new Soldier(person5, 100, 10, randomOriginal);
            var soldier6 = new Soldier(person6, 100, 10, randomviaHalf);
            var soldier7 = new Soldier(person7, 100, 10, randomOriginal);

            soldiers.Add(soldier1);
            soldiers.Add(soldier2);
            soldiers.Add(soldier3);
            soldiers.Add(soldier4);
            soldiers.Add(soldier5);
            soldiers.Add(soldier6);
            soldiers.Add(soldier7);

            return soldiers;
        }
    }
}
