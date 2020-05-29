using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Espresso : Coffee
    {
        public Espresso()
        {
            SetDescription ("意大利咖啡");
            Price = 6m;
        }
    }
}
