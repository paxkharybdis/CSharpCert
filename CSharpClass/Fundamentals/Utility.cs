using System;

namespace Fundamentals
{
    public static class Utility
    {
        const int _myFirst = 5;
        static int _mySecond = 7;

        static Utility()
        {
            _mySecond = 10;
            Console.WriteLine("Utility Constructor");
        }

        public static int AddTwoNumbersSortOf(int value1, int value2 = _myFirst)
        {
            return value1 + value2;
        }



    }
}