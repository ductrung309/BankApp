using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public abstract class BankAccount
    {
        private string AccountNumber;
        private decimal Balance;
        public BankAccount(string accountNumber, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }
        public string accountNumber
        {
            get { return AccountNumber; }
        }
        public decimal balance
        {
            get { return Balance; }
            set { if (value >= 0) Balance = value;
                else throw new ArgumentException("Balance cannot be negative");
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative");
            else
            {
                balance += amount;
            }
        }
        public virtual void WithDraw(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative");
            else
            {
                balance -= amount;
                Console.WriteLine($"{amount:C} deposited. New balance: {balance:C}");
            }
        }
        public abstract void ApplyMonthlyInterest();
    }
}
