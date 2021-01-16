using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ContractEmployee : IEmployee
    {
        public decimal GetBonus()
        {
            return 3;
        }

        public decimal GetPay()
        {
            return 12;
        }
    }
}
