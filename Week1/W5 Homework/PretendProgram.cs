using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.W5_Homework
{
    class PretendProgram
    {
        public delegate void TryOn(string type);

        static void PretendMain(string[] args)
        {


        }


        private static void DelegateSample()
        {
            Hats myHat = new Hats("Cowboy", 7);
            TryOn theHat = myHat.TryOnHat;
            theHat("I tried on a " + myHat.HatType + "hat that was size " + myHat.HatSize);

            Hats mySecond = new Hats();
        }

    }
}
