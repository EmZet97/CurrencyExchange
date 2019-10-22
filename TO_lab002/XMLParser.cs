using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TO_lab002
{
    class XMLParser : IParser
    {
        //private string URL;
        private string date;
        string xml;

        public XMLParser(string xml)
        {
            this.xml = xml;
        }

        public Repository Parse(out Repository repository)
        {
            repository = new Repository();
            foreach(Currency curr in GetCurrency())
            {
                repository.AddCurrency(curr);
            }
            if (date != null)
            {
                repository.Date = date;
            }
            return repository;
        }

        private IEnumerable<Currency> GetCurrency()
        {
            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                string nazwa = "", kod = "", kurs = "";
                int size = 0;
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "data_publikacji":
                                this.date = reader.ReadString();
                                break;
                            case "nazwa_waluty":
                                nazwa = reader.ReadString();
                                size++;
                                break;
                            case "kod_waluty":
                                kod = reader.ReadString();
                                size++;
                                break;
                            case "kurs_sredni":
                                kurs = reader.ReadString();
                                size++;
                                break;
                        }
                        if (size == 3)
                        {
                            decimal val = decimal.Parse(kurs, System.Globalization.NumberStyles.AllowDecimalPoint);
                            size = 0;
                            Currency new_curr = new Currency(nazwa, kod, val);
                            yield return new_curr;
                        }
                    }
                }
            }
        }
    }
}
