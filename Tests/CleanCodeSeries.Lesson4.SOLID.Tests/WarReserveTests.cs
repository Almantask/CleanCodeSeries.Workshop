using System;
using System.Collections.Generic;
using System.Linq;
using CleanCodeSeries.Workshop.Lesson3.EasyOOP;
using CleanCodeSeries.Workshop.Lesson4.SOLID;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;


namespace CleanCodeSeries.Lesson4.SOLID.Tests
{
    [TestClass]
    public class GeneratorTests
    {
        [TestMethod]
        public void Generate_Success()
        {
            var mock = new Mock<ISoldierGenerator>();
            var expectedServe = new List<Soldier>() { null, null };
            mock.Setup(s => s.Generate())
                .Returns(expectedServe);

            var war = new War(mock.Object);
            var reserve = war.Reserve;

            const int expected = 2;
            Assert.AreEqual(expected, reserve.Count);
        }

    }
}
