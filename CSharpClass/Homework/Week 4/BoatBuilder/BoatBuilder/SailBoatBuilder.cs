using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatBuilderPattern
{
    class SailBoatBuilder : BoatBuilder
    {
        private IBoat sailBoatInProgress;

        public override IBoat Boat
        {
            get { return sailBoatInProgress; }
        }
    }
}
