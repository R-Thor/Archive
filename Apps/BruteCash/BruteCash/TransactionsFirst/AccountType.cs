using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BruteCash
{
    public enum ACCOUNT_TYPE
    {
        //Debit Increased
        Dividend,// (Draws)
        Expense,
        Asset,
        Loss,
        //Credit Increased
        Gain,
        Income,
        Revenue,
        Liability,
        Equity, //Stockholders' (Owner's) Equity
    }
}
