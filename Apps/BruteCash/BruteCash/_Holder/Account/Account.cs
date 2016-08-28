using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BruteCash.Business;

namespace BruteCash.Business
{
    public abstract class Account
    {
        //public double TrialBalanceType { get; set; }
        //public double TrialBalance()
        //{
        //    return (TrialBalanceType.CalculateTrialBalance());
        //}

        public string Name { get; set; }

        public Dictionary<string,string> Identification { get; set; }

        public Dictionary<string, string> Address { get; set; }

        public Balance Balance
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Transaction LastTransaction
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
