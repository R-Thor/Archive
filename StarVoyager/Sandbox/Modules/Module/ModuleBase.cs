using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modules
{
    abstract class ModuleBase
    {
        Dimensions _dimensions;

        internal Dimensions Dimensions
        {
            get { return _dimensions; }
            set { _dimensions = value; }
        }

        Construction _construction;

        internal Construction Construction
        {
            get { return _construction; }
            set { _construction = value; }
        }

        LifeSupport _lifeSupport;

        internal LifeSupport LifeSupport
        {
            get { return _lifeSupport; }
            set { _lifeSupport = value; }
        }
    }
}
