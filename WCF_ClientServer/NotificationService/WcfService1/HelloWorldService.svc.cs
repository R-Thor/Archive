﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    [ServiceContract]
    public class HelloWorldService// : IService1
    {
        [OperationContract]
        public string GetData(string Name)
        {
            return string.Format("Hello {0}", Name);
        }
    }
}
