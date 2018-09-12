using System;
using Week1.W1_Homework.csharpcertw1hmwk;
using Week1.Week2;
using Week1.Week2.week2homework;
using Fundamentals;

namespace Week1
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                string menuInput;

                // Present menu.
                Console.WriteLine("================================================");
                Console.WriteLine("Which C# code example would you like to execute?");
                Console.WriteLine("Week 1: Basic Class Functions.  (1)");
                Console.WriteLine("Week 2: Counting To Ten.        (2)");
                Console.WriteLine("Week 2: Display Grades.         (3)");
                Console.WriteLine("Week 3: Virtual Bicycle Shop    (4)");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("================================================");

                menuInput = Console.ReadLine();

                // 
                switch (menuInput)
                {
                    case "1":
                        Console.WriteLine("Basic Class Functions.");
                        Bicycle bicycle = new Bicycle();
                        bicycle.showAll();
                        break;
                    case "2":
                        Console.WriteLine("Count To Ten");
                        CountToTen counting = new CountToTen();
                        counting.Counting();
                        break;
                    case "3":
                        Console.WriteLine("The Great Grade Displayer!!");
                        gradeswitch gradeswitch = new gradeswitch();
                        gradeswitch.gradeMenu();
                        break;
                    case "4":
                        Console.WriteLine("Loading Virtual Bicycle Shop");
                        bicycle2 bicycle2 = new bicycle2();
                        bicycle2.bikeMenu();
                        break;
                    case "5":

                        break;
                }





            } while (true);


            /*Square mySquare = new Square(3, 3);

            //int length, height;
            var (length, height) = mySquare;

            // The below statement does the same thing as the VAR statement above.
            // mySquare.Deconstruct(out length, out height);

            Console.WriteLine(mySquare.Length);
            Console.WriteLine(length);

            Square yourSquare = new Square{Length = 5, Height = 5, Color = "Blue"};

            Square happySquare = new Square{ Color = "Brown"};
            */
        }


    }
}
