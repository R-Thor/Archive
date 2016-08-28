using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;

[ServiceContract(Namespace = "361F7431-C25E-4845-BE1D-2CEED7EA71AA")]//wsdl
public interface IHelloWCFService
{
    [OperationContract]
    string SayHello(string msg);
}

namespace HelloWCFClientConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HelloWCFClientConsoleApplication";
            IHelloWCFService proxy = ChannelFactory<IHelloWCFService>.CreateChannel(
                new NetTcpBinding(),
                new EndpointAddress("net.tcp://localhost:9000/HelloWcfEndPoint"));
            for(;;)
            {
                Console.WriteLine("Enter text and hit return: ");
                string msg = Console.ReadLine();
                string result = proxy.SayHello(msg);
                Console.WriteLine("Server returned: " + result);
            }
        }
    }
}
