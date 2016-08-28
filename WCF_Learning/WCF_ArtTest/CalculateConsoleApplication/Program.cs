using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculateConsoleApplication.ServiceReference1;
namespace CalculateConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceClient calculatorServiceClient = new CalculatorServiceClient();
            for (; ; )
            {
                double A = double.Parse(Console.ReadLine());
                double B = double.Parse(Console.ReadLine());
                char O = char.Parse(Console.ReadLine());
                double result = calculatorServiceClient.Calculate(A,B ,O );
                Console.WriteLine(string.Format("{0} {1} {2} = {3}",A,O,B,result));

            }
            
        }
    }
}
