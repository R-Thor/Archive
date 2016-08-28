using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Animals
{
    class Bird: Animal
    {
        public Bird():base()
        {
            this.FlyType = new CanFly();
        }
    }
}
