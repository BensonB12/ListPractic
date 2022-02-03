using System;
using System.IO;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("to exit press \"x\"");
            var allLines =File.ReadAllLines("Ston.txt");
            var textReader = new StreamReader("Ston.txt");
            string firstLine = textReader.ReadLine();
            
            foreach (var item in allLines)
            {
            Console.WriteLine(item);
            }
            
            textReader.Close();
            
            if (firstLine == " ")
            {
                var textWriter = new StreamWriter("Ston.txt");
                textWriter.WriteLine("Ston");
                textWriter.Close();
            }

            while (true)
            {
                var list = new List<string>();
                string input = Console.ReadLine();
               
                if (input == "x")
                {
                    return;
                }

                list.Add(input);
                File.AppendAllLines("Ston.txt", list);
            }
        }
    }
}
























//    var list = new List<string>();
//    list.Add(".");
//    list.Add("I love writing books!");

//    File.AppendAllLines("Ston.txt", list); 