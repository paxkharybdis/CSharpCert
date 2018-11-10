using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBoatFactory
{
    public abstract class AbstractBoatFactory
    {
        public abstract IBoatHull CreateBoatHull();
        public abstract IBoatMotor CreateBoatMotor();
    }
}
