using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.W5_Homework
{
    public delegate int TheMagicNumber(int magicNumber);

    public class DelegateExample
    {

        public event TheMagicNumber LuckyNumber;

        public int MyNumber { get; set; }

        public void TheMagicNumber()
        {
            this.LuckyNumber += new TheMagicNumber(GenerateNum);

            //MyNumber = GenerateNum(magicNumber);

        }

        public static int GenerateNum(int magicNumber)
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 255);
            return rand;

        }

    }
}

