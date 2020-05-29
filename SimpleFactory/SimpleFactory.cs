using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SimpleFactory
    {
        public Pizza CreatePizza(string orderType)
        {
            Pizza pizza = null;
            if (orderType.Equals("chess"))
            {
                pizza = new ChessPizza("chess");
            }
            else if (orderType.Equals("greece"))
            {
                pizza = new GreecePizza("greece");
            }
            else if (orderType.Equals("chinese"))
            {
                pizza = new ChinesePizza("chinese");
            }

            return pizza;
        }
    }
}
