using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 装饰类
    /// </summary>
    public class Decorator : Drink
    {
        public Decorator(Drink drink)
        {
            obj = drink;
        }

        public override decimal Cost()
        {
            var d = Price + obj.Price;
            if (obj is Decorator)
            {
                Decorator temp = obj as Decorator;
                while (temp!=null&& temp.obj!=null)//这里会有回溯
                {
                    d += temp.obj.Price;
                    temp = temp.obj as Decorator;
                }
            }

            return d;
        }

        public new string GetDescription()
        {
            if (obj is Decorator)//这里会有回溯
            {
                return base.GetDescription() + " " + Price + "元" + "&&" + (obj as Decorator).GetDescription();
            }
            return base.GetDescription() + " " + Price + "元" + "&&" + obj.GetDescription();
        }

        Drink obj;//被装饰的
    }
}
