using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.W5_Homework
{
    class PretendProgram
    {
        public delegate int TheMagicNumber(int _magicNumber);
        public int _magicNumber { get; set; }

        static void PretendMain(string[] args)
        {
            DelegateSample();
        }


        private static int DelegateSample()
        {

            DelegateExample delegateExample = new DelegateExample();
            DelegateExample.TheMagicNumber theMagicNumber = new DelegateExample.TheMagicNumber(delegateExample.TheLuckyNumber());
            int result = theMagicNumber(7777);
            Console.WriteLine("Your Lucky Number is " + result + ".");
            return result;
        }
    }
}
