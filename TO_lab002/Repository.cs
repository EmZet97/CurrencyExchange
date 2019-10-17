using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_lab002
{
    class Repository
    {
        private List<Currency> currencies = new List<Currency>();

        public Currency[] GetCurrencies()
        {
            return currencies.ToArray();
        }

        public Currency GetCurrencyByCode(string code)
        {
            foreach(Currency c in currencies)
            {
                if (c.GetCode() == code)
                    return c;
            }

            return null;
        }

        public void AddCurrency(Currency currency)
        {
            currencies.Add(currency);
        }
        public void RemoveCurrency(Currency currency) => currencies.Remove(currency);
    }
}
