using System;

namespace Week1.Week2
{
    public class CountToTen
    {
        public void Counting()
       {
            // Set integer value
            int num = 1;
            // Add 1 to int until condition is met.
            while(num < 11)
            {
                Console.WriteLine(num);
                num++;
            }
        }
    }
}