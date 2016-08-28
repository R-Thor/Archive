using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCF_GameServiceLibrary
{
    [ServiceContract(Namespace="9697BC77-AE5E-4876-B03F-3C2E8E1CB9F3")]
    public interface ILogonService
    {
        [OperationContract]
        Guid? Logon(string Logon, string Password);
    }
}
