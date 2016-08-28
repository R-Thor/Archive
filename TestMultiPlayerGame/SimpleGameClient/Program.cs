using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGameClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            x.Open();
            while (1 == 1)
            {
                Console.WriteLine(x.GetData(int.Parse(Console.ReadLine().ToString())));
                Console.WriteLine(x.GetSessionGuid());
            }
        }
    }
}
