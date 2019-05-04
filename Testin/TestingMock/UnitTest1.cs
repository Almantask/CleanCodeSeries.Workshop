using Xunit;
using FluentAssertions;
using System;

namespace TestingMock
{
    public class AccountTest
    {
        [Fact]
        public void TransferFunds_Ok()
        {
            var source = new Account();
            source.Deposit(200);

            var destination = new Account();
            destination.Deposit(150);
            source.TransferFunds(destination, 100);

            destination.Balance.Should().Be(250);
            source.Balance.Should().Be(100);
        }
        
        [Fact]
        public void TransferFunds_InsuficientFunds_Fail()
        {
            var source = new Account();
            source.Deposit(200);
            var destination = new Account();

            Action transferAction = () => source.TransferFunds(destination, decimal.MaxValue);
            transferAction.Should().ThrowExactly<InsuficientFundsException>();
        }
    }

}
