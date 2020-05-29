using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 装饰者模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //下订单：2巧克力 1牛奶 的 longblack

            //1 longblack
            Drink order = new LongBlack();
            Console.WriteLine("费用:\t"+order.Cost());
            Console.WriteLine("描述:\t"+order.GetDescription());

            //2 加牛奶
            order = new Milk(order);
            Console.WriteLine("费用:\t" + order.Cost());
            Console.WriteLine("描述:\t" + (order as Decorator).GetDescription());

            //3 加巧克力
            order = new Chocolate(order);
            Console.WriteLine("费用:\t" + order.Cost());
            Console.WriteLine("描述:\t" + (order as Decorator).GetDescription());

            //3 加巧克力
            order = new Chocolate(order);
            Console.WriteLine("费用:\t" + order.Cost());
            Console.WriteLine("描述:\t" + (order as Decorator).GetDescription());

            Console.ReadLine();
        }
    }
}
