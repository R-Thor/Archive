using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HelloWCFHostConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HelloWCFHostConsoleApplication";
            using (ServiceHost host = new ServiceHost(typeof(HelloWCFServiceLibrary.HelloWCFService)))
            {
                host.AddServiceEndpoint(typeof(HelloWCFServiceLibrary.IHelloWCFService),
                    new NetTcpBinding(),
                    "net.tcp://localhost:9000/HelloWcfEndPoint");
                host.Open();
                Console.ReadLine();
            }
        }
    }
}
