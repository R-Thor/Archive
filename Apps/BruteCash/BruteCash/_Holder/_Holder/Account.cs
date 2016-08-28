using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BruteCash
{
    public abstract class Account
    {
        public AccountingType AccountType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<Account> Accounts
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<Entity> Responsible { get; set; }

        public decimal Balance
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
