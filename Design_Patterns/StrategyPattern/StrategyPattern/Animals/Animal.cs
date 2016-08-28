using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Animals
{
    public abstract class Animal
    {
        private IFly _flyType;

        internal IFly FlyType
        {
            get { return _flyType; }
            set { _flyType = value; }
        }

        public string tryToFly()
        {
            return FlyType.Flys();
        }

    }
}
