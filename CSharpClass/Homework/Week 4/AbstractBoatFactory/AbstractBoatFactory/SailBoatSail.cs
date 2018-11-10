using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBoatFactory
{
    class SailBoatSail : IBoatMotor
    {
        public virtual string BoatMotorParts
        {
            get { return "Parts for Sailboat Sail"; }
        }
    }
}
