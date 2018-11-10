using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBoatFactory
{
    public class SailBoatFactory : AbstractBoatFactory
    {
        public override IBoatHull CreateBoatHull()
        {
            return new SailBoatHull();
        }

        public override IBoatMotor CreateBoatMotor()
        {
            return new SailBoatSail();
        }
    }
}
