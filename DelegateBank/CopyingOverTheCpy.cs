using System;
using System.Collections;

public interface IAccount2
{
    string Name { get; }
    decimal Balance { get; }
    void AddDeposite(decimal depositeAmount);
    void Withdraw(decimal withdrawAmount);
}

public class Account2 : IAccount2
{

    private string name;
    public Account2(string nName)
    {
        this.name = nName;
    }
    private decimal balance = 0;
    public string Name => name;

    public decimal Balance => balance;
    public void AddDeposite(decimal depositeAmount)
    {
        balance += depositeAmount;
        Console.WriteLine("It worked!");
    }

    public void Withdraw(decimal withdrawAmount)
    {
        balance -= withdrawAmount;
        Console.WriteLine("Money Withdrwan");
    }
}

public class Bank2
{
    private Hashtable allAccounts;
    public Bank2()
    {
        allAccounts = new Hashtable();
    }

    public void AddAccount(IAccount2 accountbox)
    {
        allAccounts.Add(accountbox.Name, accountbox);
    }

    public IAccount2 GetAccountInBank(string Name)
    {
        return allAccounts[Name] as IAccount2;
    }
    
}