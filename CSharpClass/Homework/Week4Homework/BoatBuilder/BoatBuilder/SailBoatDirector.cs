using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatBuilderPattern
{
    class SailBoatDirector : BoatDirector
    {
        public override IBoat Build(BoatBuilder builder)
        {
            builder.BuildBoatHull();
            return builder.Boat;
        }
    }
}
