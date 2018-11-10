using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBoatFactory
{
    class MotorBoatFactory : AbstractBoatFactory
    {
        public override IBoatMotor CreateBoatMotor()
        {
            return new MotorBoatMotor();
        }

        public override IBoatHull CreateBoatHull()
        {
            return new MotorBoatHull();
        }
    }

}
