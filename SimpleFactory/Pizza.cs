using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class Pizza
    {
        string name;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine(name + "baking");
        }
        public void Cut()
        {
            Console.WriteLine(name + "cuting");
        }
        public void Box()
        {
            Console.WriteLine(name + "boxing");
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
