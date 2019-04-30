using System;
using System.Collections.Generic;
using CleanCodeSeries.Workshop.Lesson4.EasyOOP;
using CleanCodeSeries.Workshop.Lesson4.SOLID;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace CleanCodeSeries.Lesson4.SOLID.Tests
{
    [TestClass]
    public class SoldierTests
    {
        [TestMethod]
        public void Shoot_WasHit()
        {
            var random = new MockedRandomViaInterface();

            var person = new Person("Tom", 40, 81, 180);
            var soldier = new Soldier(person, 100, 0, random);
            var soldier2 = new Soldier(person, 100, 10, random);

            var targets = new List<Soldier>() { soldier2 };

            const float damage = 50;

            soldier.Shoot(targets);
            soldier2.HP.Should().Be(50);
        }

        [TestMethod]
        public void Shoot_WasNotHit()
        {
            var random = new RandomiserZero();

            var person = new Person("Tom", 40, 81, 180);
            var soldier = new Soldier(person, 100, 0, random);
            var soldier2 = new Soldier(person, 100, 10, random);

            var targets = new List<Soldier>() { soldier2 };

            const float damage = 50;
            var initialHp = soldier2.HP;
            soldier.Shoot(targets);
            soldier2.HP.Should().Be(initialHp);
        }


    }
}
