using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class GreecePizza : Pizza
    {
        public GreecePizza(string name)
        {
            this.SetName(name);
        }
        public override void Prepare()
        {
            Console.WriteLine(GetName() + "准备原材料");
        }
    }
}
