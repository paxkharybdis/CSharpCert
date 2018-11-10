using System;

namespace Fundamentals
{
    public class Square : Shape
    {
        // properties
        public int Length { get; set;}
        public int Height { get; set;}
        public string Color { get; set; }

        public override int Sides { get; set; }

        // constructor
        public Square (int length, int height)
        {
            this.Length = length;
            this.Height = height;
        }

        public Square () { }

        // method
        public void Deconstruct(out int length, out int height)
        {
            length = this.Length;
            height = this.Height;
        }

        public override double Area()
        {
            return 45.0;
        }

        public override void MyCoolMethod()
        {
            
        }

        void Something()
        {
            System.Convert.ToDouble(23.4f);

        }
    }
}