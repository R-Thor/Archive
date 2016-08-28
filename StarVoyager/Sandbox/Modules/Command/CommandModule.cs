using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modules
{
    abstract class CommandModule: ModuleBase
    {
        SortedList<int, Workstation> Workstations;
    }
}
