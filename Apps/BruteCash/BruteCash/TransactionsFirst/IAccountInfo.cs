using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BruteCash
{
    public interface IAccountInformation
    {

        string Name
        {
            get;
            set;
        }

        string Identifier
        {
            get;
            set;
        }

        List<Account> ChildAccounts
        {
            get;
            set;
        }
    }
}
