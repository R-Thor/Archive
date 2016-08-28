using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExecuteProcAtSec
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DatabaseLoad databaseLoad = new DatabaseLoad(5, 60);
            while (Console.ReadLine().Equals("Exit",StringComparison.OrdinalIgnoreCase));
        }
    }
}
