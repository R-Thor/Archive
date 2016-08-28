using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCF_GameServiceLibrary
{
    public class LogonService : ILogonService
    {
        public Guid? Logon(string Logon, string Password)
        {
            Console.WriteLine(string.Format("Logon: {0} Password: {1}", Logon, Password));
            if (Logon.Length > 0 && Password.Length > 0)
            {
                return (Guid.NewGuid());
            }
            return (null);
        }
    }
}
