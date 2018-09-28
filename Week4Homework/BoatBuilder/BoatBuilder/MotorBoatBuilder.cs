using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatBuilderPattern
{
    public class MotorBoatBuilder : BoatBuilder
    {
        private IBoat motorBoatInProgress;

        public override IBoat Boat
        {
            get { return motorBoatInProgress; }
        }

        public override void BuildBoatHull()
        {
            Console.WriteLine("Building Motorboat Hull");
        }
    }
}
