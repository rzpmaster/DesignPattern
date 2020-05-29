using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Chocolate : Decorator
    {
        public Chocolate(Drink drink) : base(drink)
        {
            SetDescription("巧克力");
            Price = 3m;
        }
    }
}
