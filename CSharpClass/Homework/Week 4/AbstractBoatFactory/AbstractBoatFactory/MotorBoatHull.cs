using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBoatFactory
{
    public class MotorBoatHull : IBoatHull
    {
        public virtual string BoatHullParts
        {
            get { return "Parts for Boat Hull"; }
        }
    }
}
