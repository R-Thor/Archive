using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.Animals
{
    interface IFly
    {
        string Flys();
    }
    class CanFly:IFly
    {
        public string Flys()
        {
            return ("Flying");
        }
    }
    class CantFly : IFly
    {
        public string Flys()
        {
            return ("I can't fly");
        }
    }
}
