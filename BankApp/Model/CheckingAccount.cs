using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
    public class CheckingAccount : BankAccount
    {
        private decimal WithdrawalLimit;
        public CheckingAccount(string AccountNumber, decimal Balance, decimal withdrawalLimit):base(AccountNumber, Balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }
        public decimal withdrawalLimit
        {
            get { return WithdrawalLimit; } 
            set {
                if (value < 0) throw new ArgumentOutOfRangeException("Limit cannot be negative");
                else WithdrawalLimit = value;
            }
        }
        public override void WithDraw(decimal amount)
        {
            if (amount > WithdrawalLimit) Console.WriteLine($"Withdrawal denied. Exceeds limit of {WithdrawalLimit:C}");
            else base.WithDraw(amount);
        }
        public override void ApplyMonthlyInterest()
        {
            Console.WriteLine("Checking accounts do not earn interest.");
        }
    }
}
