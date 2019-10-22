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
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public List<Currency> Currencies
        {
            get
            {
                return currencies;
            }
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

        public Currency GetCurrencyByIndex(int index)
        {
            return currencies[index];
        }

        public void AddCurrency(Currency currency)
        {
            currencies.Add(currency);
        }
        public void RemoveCurrency(Currency currency)
        {
            currencies.Remove(currency);
        }
    }
}
