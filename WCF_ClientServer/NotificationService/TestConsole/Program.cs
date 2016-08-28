using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestConsole");
            string User = WindowsIdentity.GetCurrent().Name.ToString().Split(new char[] {'\\'})[1];
            Console.WriteLine("User " + User);
            string ConsoleEntry = string.Empty;
            while (ConsoleEntry.ToUpper()!="Bye".ToUpper())
            {
                Console.Write("> ");
                ConsoleEntry = Console.ReadLine();
                HelloWorldService.HelloWorldServiceClient hwsc = new HelloWorldService.HelloWorldServiceClient();
                hwsc.Open();
                Console.WriteLine(hwsc.GetData(ConsoleEntry).ToString());
                hwsc.Close();
            }
        }
    }
}
