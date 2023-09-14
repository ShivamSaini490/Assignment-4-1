using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Error: Balance cannot be set to a negative value.");
            }
            else
            {
                balance = value;
            }
        }
    }

    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Error: Deposit amount must be greater than zero.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Error: Withdrawal amount must be greater than zero.");
        }
        else
        {
            Console.WriteLine("Error: Insufficient funds for withdrawal.");
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(1000);

        account.Deposit(500);
        account.Withdraw(200);
        account.Withdraw(1500);

        account.Balance = -100;

        Console.ReadLine();
    }
}
