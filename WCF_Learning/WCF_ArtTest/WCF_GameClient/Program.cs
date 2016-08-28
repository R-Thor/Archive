using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCF_GameClient
{
    [ServiceContract(Namespace = "9697BC77-AE5E-4876-B03F-3C2E8E1CB9F3")]
    public interface ILogonService
    {
        [OperationContract]
        Guid? Logon(string Logon, string Password);
    }

    class Program
    {
        static Guid? SessionToken { get; set; }
        static void Main(string[] args)
        {

            Console.Title = "WCF_GameClient";
            ILogonService proxy = ChannelFactory<ILogonService>.CreateChannel(
                new NetTcpBinding(),
                new EndpointAddress("net.tcp://localhost:9000/GameHostEndPoint"));
            for (int logonAttemptCount = 0 ; logonAttemptCount < 3 ; logonAttemptCount++)
            {
                Console.WriteLine("Enter text and hit return: ");
                string UserName = Console.ReadLine();
                string Password = Console.ReadLine();
                Guid? result = proxy.Logon(UserName, Password);
                Console.WriteLine("Server returned: " + result);
                if (result !=null)
                {
                    SessionToken = result;
                    break;
                }
            }
            if (SessionToken != null)
            {
                GoGame();
            }
            else
            {
                Console.WriteLine("Logon Failed");
            }
        }
        static void GoGame()
        {
            Console.WriteLine(String.Format("Game Session: {0}",SessionToken));
            Console.ReadKey();
        }
    }
}
