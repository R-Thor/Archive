using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Partials
{
    partial class PartialClass
    {
        public int MyProperty { get; set; }
        partial void PartialFunction()
        {
            Console.WriteLine("PartialFunction_2");
        }
    }
}
