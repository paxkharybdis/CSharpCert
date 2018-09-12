using System;
using Week1.W1_Homework.csharpcertw1hmwk;
using Week1.Week2;
using Fundamentals;

namespace Week1
{
    class Program
    {
       
        //gradeswitch myGradeswitch = new 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
       
        Square mySquare = new Square(3, 3);
        
        //int length, height;
        var (length, height) = mySquare;

        // The below statement does the same thing as the VAR statement above.
        // mySquare.Deconstruct(out length, out height);

        Console.WriteLine(mySquare.Length);
        Console.WriteLine(length);
       
        Square yourSquare = new Square{Length = 5, Height = 5, Color = "Blue"};

        Square happySquare = new Square{ Color = "Brown"};
       
       
       
        }
        
        
    }
}
