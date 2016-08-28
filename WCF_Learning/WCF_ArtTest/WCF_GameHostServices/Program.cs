using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCF_GameHostServices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WCF_GameHostServices";
            using (ServiceHost host = new ServiceHost(typeof(WCF_GameServiceLibrary.LogonService)))
            {
                host.AddServiceEndpoint(typeof(WCF_GameServiceLibrary.ILogonService),
                    new NetTcpBinding(),
                    "net.tcp://localhost:9000/GameHostEndPoint");
                host.Open();
                Console.ReadLine();
            }
        }
    }
}
