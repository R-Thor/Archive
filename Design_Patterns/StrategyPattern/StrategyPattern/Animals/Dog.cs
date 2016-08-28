using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Animals
{
    public class Dog:Animal
    {
        public Dog():base()
        {
            this.FlyType = new CantFly();
        }
    }
}
