// using System;
// using System.IO;
// using System.Collections.Generic;

// namespace DelegateBank // Note: actual namespace depends on the project name.
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//         }
//     }
// }

using System;
public delegate decimal SecondDelegate();
public delegate decimal CalculateFee(decimal balance);
public class PoopiePants
{
    public static decimal Method1()
    {
        return 555;
    }
    public static decimal RipoffFee(decimal balance)
    {
        Console.WriteLine("Calling the Ripoff Method");
        if (balance < 0)
        {
            return 100;
        }
        else
        {
            return 1;
        }
    }
    public static decimal FriendlyFee(decimal balance)
    {
        Console.WriteLine("Calling the Friendly Method");
        if (balance < 0)
        {
            return 10;
        }
        else
        {
            return 1;
        }
    }

    public static void Main()
    {
        CalculateFee calc = new CalculateFee(RipoffFee);
        Console.WriteLine(calc(-1)); // this will call the Ripoff method
        calc = new CalculateFee(FriendlyFee);
        Console.WriteLine(calc(-1)); // this will call the Friendly method
        SecondDelegate calc2 = new SecondDelegate(Method1);
        Console.WriteLine(calc2);
    }
}