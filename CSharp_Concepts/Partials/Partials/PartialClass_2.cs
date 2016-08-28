using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Partials
{
    partial class PartialClass
    {
        public int MyProperty2 { get; set; }
        partial void PartialFunction();
        public PartialClass()
        {
            PartialFunction();
        }
        //{
        //    Console.WriteLine("PartialFunction_2");
        //}

    }
}
