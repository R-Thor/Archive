using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HelloWCFServiceLibrary
{
    [ServiceContract(Namespace="361F7431-C25E-4845-BE1D-2CEED7EA71AA")]//wsdl
    public interface IHelloWCFService
    {
        [OperationContract]
        string SayHello(string msg);
    }
}
