using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BruteCash
{
    public class Accounts:List<Account>
    {
        public decimal ProfitBalance { get; set; }
        public decimal LossBalance { get; set; }
    }
}
