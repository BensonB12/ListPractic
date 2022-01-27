using System;
using System.Collections.Generic;

namespace interfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var favriotMoves = new List<string>();
            favriotMoves.Add("No time to die");
            favriotMoves.Add("The dark night");
            foreach (var item in favriotMoves)
            {
                Console.WriteLine(item);
            }

        }
    }
    // interface is a contianer of requirements that we should have 
    interface IBook
    {
        public bool TableOfContents();
        public int GetNumberOfPages();
        public bool CoverPage();
    }
    public class HarrayPotter : IBook
    {
        private int numberOfPages; 
        public HarrayPotter(int InNumberOfPages )
        {
            numberOfPages = InNumberOfPages;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }

        public bool CoverPage()
        {
            throw new NotImplementedException();
        }


        public bool TableOfContents()
        {
            throw new NotImplementedException();
        }
    }
    public class StarWars : IBook
    {
        public bool CoverPage()
        {
            throw new NotImplementedException();
        }

        public int GetNumberOfPages()
        {
            throw new NotImplementedException();
        }

        public bool TableOfContents()
        {
            throw new NotImplementedException();
        }
    }
}


































/*
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
*/
