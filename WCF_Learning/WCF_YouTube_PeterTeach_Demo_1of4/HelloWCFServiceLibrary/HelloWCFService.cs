using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWCFServiceLibrary
{
    public class HelloWCFService:IHelloWCFService
    {
        public string SayHello(string msg)
        {
            Console.WriteLine("Recieved from client: " + msg);
            return (String.Format("You entered: {0} - Time:{1}", msg, DateTime.Now));
        }
    }
}
