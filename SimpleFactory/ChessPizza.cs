using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class ChessPizza : Pizza
    {
        public ChessPizza(string name)
        {
            this.SetName(name);
        }
        public override void Prepare()
        {
            Console.WriteLine(GetName()+ "准备原材料");
        }
    }
}
