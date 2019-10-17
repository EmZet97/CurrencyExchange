using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TO_lab002
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLParser parser = new XMLParser("http://www.nbp.pl/kursy/xml/lasta.xml");
            Repository repository;
            parser.Parse(out repository);
            foreach (Currency c in repository.GetCurrencies())
            {
                Console.WriteLine(c.GetName() + "( " + c.GetCode() + " ) = " + c.GetValue());
            }
            List<string> someList;
            //IEnumerable<string> myEnumerable = repository.GetCurrencies().Where(c.);
            Console.ReadKey();

        }
        
        
        
    }
   
}
