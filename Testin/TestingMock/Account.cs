using System;

namespace TestingMock
{
    internal class Account
    {
        public Account()
        {
        }

        public decimal Balance { get; internal set; }

        internal void Deposit(decimal v)
        {
            throw new NotImplementedException();
        }

        internal void TransferFunds(Account destination, decimal v)
        {
            throw new NotImplementedException();
        }
    }
}