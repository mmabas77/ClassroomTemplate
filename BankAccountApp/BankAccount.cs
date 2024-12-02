using System;
using System.Diagnostics;
using System.Threading;

namespace BankAccountApp
{
    public class BankAccount
    {
        private decimal _balance;

        // TODO: Declare a lock object for thread synchronization
        private readonly object _lock = new object();

        // Constructor
        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        // TODO: Implement the Deposit method
        // This method should:
        // 1. Use a synchronization mechanism to protect the shared balance.
        // 2. Add the amount to the balance.
        // 3. Print a message showing the deposit amount and new balance.
        public void Deposit(decimal amount)
        {
            throw new NotImplementedException("Deposit method not implemented");
        }

        // TODO: Implement the Withdraw method
        // This method should:
        // 1. Use a synchronization mechanism to protect the shared balance.
        // 2. Check if there are sufficient funds before withdrawing.
        // 3. Subtract the amount from the balance if possible.
        // 4. Print a message showing the withdrawal amount and remaining balance.
        // 5. If insufficient funds, print an appropriate message.
        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException("Withdraw method not implemented");
        }

        // Method to get the current balance
        // Modify this method to use a synchronization mechanism to protect the shared balance.
        public decimal GetBalance()
        {
            throw new NotImplementedException("GetBalance method not implemented");
        }

        static void Main(string[] args)
        {
            // Do what ever you want here
            Console.WriteLine("Test your code in here or use the tests file !");
        }
    }
}