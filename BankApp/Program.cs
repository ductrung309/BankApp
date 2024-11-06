using BankApp.Model;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            SavingAccount savings = new SavingAccount("SA12345", 5000, 1.5m);
            CheckingAccount checking = new CheckingAccount("CA67890", 3000, 1000);

            // Thêm các tài khoản vào danh sách
            accounts.Add(savings);
            accounts.Add(checking);

            // Hiển thị thông tin tài khoản và thực hiện một số giao dịch
            foreach (var account in accounts)
            {
                Console.WriteLine($"\nAccount Number: {account.accountNumber}");
                Console.WriteLine($"Initial Balance: {account.balance:C}");

                account.Deposit(500);

                try
                {
                    account.WithDraw(700);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                account.ApplyMonthlyInterest();
                Console.WriteLine($"End of month balance: {account.balance:C}");
            }
        }
    }
}
