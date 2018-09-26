using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBoatFactory
{
    class MotorBoatMotor : IBoatMotor
    {
        public virtual string BoatMotorParts
        {
            get { return "Parts for Boat Motor"; }
        }
    }
  
}
