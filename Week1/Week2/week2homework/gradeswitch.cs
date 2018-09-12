using System;

namespace Week1.Week2.week2homework
{
    public class gradeswitch
    {
        public void gradeMenu()
        {
            // Display input request
            Console.WriteLine("Please enter a grade.");

            // Input grade and assign to variable.
            string grade = Console.ReadLine();

            // Compare input to available choices and return appropriate response.
            switch (grade)
            {
                case "E":
                case "e":
                    Console.WriteLine("Excellent");
                    break;
                case "V":
                case "v":
                    Console.WriteLine("Very Good");
                    break;
                case "G":
                case "g":
                    Console.WriteLine("Good");
                    break;
                case "A":
                case "a":
                    Console.WriteLine("Average");
                    break;
                case "F":
                case "f":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Please enter valid grade.");
                    break;
            }

        }
    }
}