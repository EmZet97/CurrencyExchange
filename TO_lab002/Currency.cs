using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_lab002
{
    class Currency
    {
        string name;
        string code;
        decimal value;

        public Currency(string name, string code, decimal value)
        {
            this.name = name;
            this.code = code;
            this.value = value;
        }

        public string GetName() => name;
        public string GetCode() => code;
        public decimal GetValue() => value;
    }
}
