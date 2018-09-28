using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatBuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BoatBuilderPattern();
        }

        private static void BoatBuilderPattern()
        {
            BoatBuilder builder = new MotorBoatBuilder();
            BoatDirector director = new MotorBoatDirector();
            IBoat boat = director.Build(builder);
            Console.WriteLine(boat);
        }
    }
}
