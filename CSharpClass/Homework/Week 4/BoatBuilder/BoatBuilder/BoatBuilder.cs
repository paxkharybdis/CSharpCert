using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatBuilderPattern
{
    public abstract class BoatBuilder
    {
        public abstract IBoat Boat { get; }

        public virtual void BuildBoatHull() { }


    }
}
