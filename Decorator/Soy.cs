using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Soy : Decorator
    {
        public Soy(Drink drink) : base(drink)
        {
            SetDescription ( "豆浆");
            Price = 1.5m;
        }
    }
}
