using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_lab002
{
    interface IParser
    {
        Repository Parse(out Repository repository);
    }
}
