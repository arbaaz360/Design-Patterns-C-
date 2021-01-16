using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class PermanentEmployee : IEmployee
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }
    }
}
