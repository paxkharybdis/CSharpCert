using System;

namespace Week1.W1_Homework.csharpcertw1hmwk
{
    // Parent class
    public class Bicycle
    {
        // Class variable: Field
        public string handlebar;

        // Class variable:  Auto Property
        public virtual int Gears { get; } = 7;

        // Class variable: Property
        public string Handlebar
        {
            set
            {
                this.handlebar = value;
            }
            get
            {
                return handlebar;
            }
        }

        // Class variable : Auto Property
        public string Wheels { set; get; }


        // Constructor
        public Bicycle()
        {
            Console.WriteLine("Bicycle Default");

        }

        // Constructor with parameter
        public Bicycle(string type)
        {
            Console.WriteLine("Bicycle with parameter");
        }

        // Method with parameter
        public void Pedal(string type)
        {
            Console.WriteLine(type);
        }

        public void showAll()
        {
            Console.WriteLine(handlebar);
            Console.WriteLine(Gears);
        }
    }
}