using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBoatFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBoatFactoryPattern();
        }

        private static void AbstractBoatFactoryPattern()
        {
            string whatToBuild = "sailboat hull";
            AbstractBoatFactory factory = null;

            if (whatToBuild.Equals("sailboat hull"))
            {
                factory = new SailBoatFactory();
            }

            else
            {
                factory = new MotorBoatFactory();
            }

            IBoatHull boatHull = factory.CreateBoatHull();
            IBoatMotor boatMotor = factory.CreateBoatMotor();

            Console.WriteLine(boatHull.BoatHullParts);
            Console.WriteLine(boatMotor.BoatMotorParts);
        }
    }
}
