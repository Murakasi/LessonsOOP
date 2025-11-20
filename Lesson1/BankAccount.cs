using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    internal class BankAccount
    {
        decimal _balance;
        public string OwnerName { get; set; }
        public decimal Balance => _balance;

        public BankAccount(string ownerName, decimal balance)
        {
            OwnerName = ownerName;
            _balance = balance > 0 ? balance : 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
            else
            {
                throw new ArgumentException("Amount must be positive!");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds");
            }
        }

        public void TransferTo(BankAccount other, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }
            if (amount > _balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            _balance -= amount;
            other.Deposit(amount);

        }
    }
}

