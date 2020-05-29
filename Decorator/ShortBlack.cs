using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ShortBlack : Coffee
    {
        public ShortBlack()
        {
            SetDescription ("shortblack");
            Price = 4m;
        }
    }
}
