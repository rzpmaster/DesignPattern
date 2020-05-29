using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LongBlack : Coffee
    {
        public LongBlack()
        {
            SetDescription ("美式咖啡");
            Price = 5m;
        }
    }
}
