using System;

namespace Fundamentals
{
    public class Square
    {
        // properties
        public int Length { get; set;}
        public int Height { get; set;}
        public string Color { get; set; }

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


        void Something()
        {
            System.Convert.ToDouble(23.4f);

        }
    }
}