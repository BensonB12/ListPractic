/*
Enums**
Structures*
Objects*
Reference types vs. value types*
Working with references*
Referential equality vs. value equality*?*
Access modifiers*
Test driven development**
Static fields*
Static methods*?*
Constructors*
Overloaded constructors*
Interfaces*
Abstract classes*
Chaining constructors*
Virtual / override*
Exceptions, custom exceptions*
Try/catch*
String manipulation*
Properties*
Delegates*
Hashtabels VS Arrays*
*/

using static System.Console;

namespace Review
{
    //Enume is a class level, it is used for very specific result. by default it is int.
    public enum Season
    {
        Spring,
        Summer,
        Autum,
        Winter
    }
    // Testing enums
    public class TestingEnums
    {
        public static void Main()
        {
        }
    }
}
// var pencil = 1;
// var pen = 1;
// WriteLine(pen.Equals(pencil));

// var word = 12;
// Console.WriteLine(word);     
// word = 100;    
// Console.WriteLine(word);   
// var sentance = 888888888;
// Console.WriteLine(sentance);   
// word = sentance;
// Console.WriteLine(word);   
// sentance = 0;
// Console.WriteLine(sentance);   
// Console.WriteLine(word);   