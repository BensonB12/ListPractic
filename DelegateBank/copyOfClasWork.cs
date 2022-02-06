using System;
using System.Collections;

public interface IAccount
{
    string Name{get;}
    decimal Balance{get;}
    void AddDeposite(decimal depositeAmount);
}

public class Account : IAccount
{
    private string name;
    private decimal balance = 5M;
    Account(string name)
    {
        this.name = name;
    }
    public string Name => name;

    public decimal Balance => balance;

    public void AddDeposite(decimal depositeAmount)
    {
        balance += depositeAmount;
        Console.WriteLine("It worked! Your balance is now: " + balance);
    }
}

public class Bank
{
    private Hashtable accounts;
    public Bank()
    {
        accounts = new Hashtable();
    }
    public void AddAccount(IAccount inAccount)
    {
        accounts.Add(inAccount.Name, inAccount);
    }
    public IAccount GetAccount(string name)
    {
        return accounts[name] as IAccount;
    }
} 