using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public class SavingAccount : BankAccount
    {
        private decimal InterestRate;
        public SavingAccount(string AccountNumber, decimal Balance, decimal InterestRate):base(AccountNumber, Balance)
        {
            this.InterestRate = InterestRate;
        }
        public decimal interestRate
        {
            get { return this.InterestRate; }
            set
            {
                if (value >= 0) InterestRate = value;
                else throw new ArgumentException("Rate cannot be negative");
            }
        }
        public override void ApplyMonthlyInterest()
        {
            decimal interest = balance * InterestRate / 100;
            Deposit(interest);
            Console.WriteLine($"Monthly interest of {interest:C} applied. New balance: {balance:C}");
        }
    }
}
