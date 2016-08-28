using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BruteCash
{
    public abstract class Account : IAccountInformation
    {
        public ACCOUNT_TYPE AccountType { get; set; }
        public List<Account> ChildAccounts { get; set; }

    }
}
