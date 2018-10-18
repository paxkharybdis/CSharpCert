using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.W5_Homework
{

    public class DelegateExample
    {
        public delegate int TheMagicNumber(int _magicNumber);


        public int TheLuckyNumber(int _magicNumber)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 255);
            return number * _magicNumber;
        }

        internal TheMagicNumber TheLuckyNumber()
        {
            return TheLuckyNumber;
        }

    }
}

