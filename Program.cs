using System;
using System.Collections.Generic;

namespace Listpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // list 
            var listOFNeeds = new List<string>();
            //adding to list
            listOFNeeds.Add("prototype");
            listOFNeeds.Add("book");
            listOFNeeds.Add("to be deleted");
            //preint only one of them
            //Console.WriteLine(listOFNeeds[0]);
            // to remove from the list
            listOFNeeds.RemoveAt(2);
            
            foreach (string item in listOFNeeds)
            {
            Console.WriteLine(item);
            }
        }
    }
}
