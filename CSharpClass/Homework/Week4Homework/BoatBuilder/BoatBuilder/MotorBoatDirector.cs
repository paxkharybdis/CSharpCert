using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatBuilderPattern
{
    public class MotorBoatDirector : BoatDirector
    {
        public override IBoat Build(BoatBuilder builder)
        {
            builder.BuildBoatHull();
            return builder.Boat;
        }


    }
}
