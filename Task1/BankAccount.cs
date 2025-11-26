using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class BankAccount
    {
        private String accountNumber;
        private double balance;

        public String AccountNumber 
        {
            get { return accountNumber; }
        }

        public double Balance 
        {
            get { return balance; }
            private set {
                if (value > 0) {
                    balance = value;
                }
            }
        }

        public BankAccount(String accNum, double initialBalance)
        {
            accountNumber = accNum;
            if (initialBalance < 0)
            {
                balance = initialBalance;
            }
            else {
                balance = 1;
            }
        }

        public void Deposit(double amount) 
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Successfully deposited: {amount}");
            }
            else {
                Console.WriteLine("Deposit must be greater than 0");

            }
        }

        public void Withdraw(double amount) 
        {
            if (amount >= 0)
            {
                Console.WriteLine("Withdraw must be greater than 0");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance");

            }
            else 
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrawn: {amount}");
            }
        }

    }

  
}
