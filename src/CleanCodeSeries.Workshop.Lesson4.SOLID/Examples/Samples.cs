using System;
using System.Security;

namespace CleanCodeSeries.Workshop.Lesson4.SOLID.Examples
{
    class Pig : Workshop.Lesson4.SOLID.Animal
    {
        // Do pig stuff
    }

    class PigMutant : Pig
    {
        private Pig _pig;
        private Mutant _mutant;

        public PigMutant(Pig pig, Mutant mutant)
        {
            _pig = pig;
            _mutant = mutant;
        }

        public void Shoot()
        {
            _mutant.Shoot();
        }
        public void Kill()
        {
            _mutant.Kill();
        }
    }



    class Dog : Animal
    {
        // Do dog stuff
    }

    class DogMutant
    {
        private Dog _dog;
        private Mutant _mutant;

        public DogMutant(Dog dog, Mutant mutant)
        {
            _dog = dog;
            _mutant = mutant;
        }

        public void Shoot()
        {
            _mutant.Shoot();
        }
        public void Kill()
        {
            _mutant.Kill();
        }
    }



    class Mutant
    {
        public void Shoot()
        {

        }
        public void Kill()
        {

        }
    }

    public class InvoiceCalculator
    {
        float Calculate(Invoice invoice)
        {
            return 0;
        }

        // ?
        public void Print()
        {

        }
    }

    internal class Invoice
    {
    }



    class Animal
    {
        public void Eat()
        {

        }
        public void Sleep()
        {

        }
    }

    class Pig:Animal
    {
        // Do pig stuff
    }

    class PigMutant:Pig
    {
        // Looks like pig,
        // but does nothing like a pig
        public void Shoot()
        {

        }
        public void Kill()
        {

        }
    }



    class Dog : Animal
    {
        // Do dog stuff
    }

    class DogMutant:Dog
    {
        // Mutant stuff again..
        public void Shoot()
        {

        }
        public void Kill()
        {

        }
    }
}