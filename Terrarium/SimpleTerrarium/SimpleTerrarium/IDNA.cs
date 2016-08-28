using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTerrarium
{
    public interface IDNA
    {
        SortedDictionary<DRIVES, Drive> Drives { get; set; }
    }
}
