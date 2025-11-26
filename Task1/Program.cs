namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("ACC123456", 500);
            Console.WriteLine();
            Console.WriteLine();
            account.Deposit(500);
            account.Withdraw(300);
            Console.WriteLine($"Remaining account balance:{account.Balance}");


            
        }
    }
}
