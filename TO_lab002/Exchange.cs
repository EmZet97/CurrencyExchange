using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_lab002
{
    class Exchange
    {
        public static decimal CurrencyConverter(decimal amount, Currency from_val, Currency to_val)
        {
            decimal v1 = from_val.GetValue();
            decimal v2 = to_val.GetValue();

            decimal finalValue = amount * v1 / v2;
            return finalValue;
        }
    }
}
