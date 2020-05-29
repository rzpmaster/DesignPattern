using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Milk : Decorator
    {
        public Milk(Drink drink) : base(drink)
        {
            SetDescription ( "牛奶");
            Price = 2m;
        }
    }
}
