using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Drink
    {
        public string description;
        public void SetDescription(string value)
        {
            description = value;
        }
        public string GetDescription()
        {
            return description;
        }


        public decimal Price { get; set; }

        //计算费用
        public abstract decimal Cost();
    }
}
