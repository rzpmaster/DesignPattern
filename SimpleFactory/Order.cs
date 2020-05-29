using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Order
    {
        public Order(SimpleFactory simpleFactory)
        {
            SetFactory(simpleFactory);
        }

        SimpleFactory factory;//工厂可以做单例，也可以成做静态方法
        Pizza pizza = null;

        public void SetFactory(SimpleFactory factory)
        {
            this.factory = factory;
        }

        public void CreateGoods()
        {
            string orderType="";
            do
            {
                orderType = GetOrderType();
                pizza = this.factory.CreatePizza(orderType);

                if (pizza!=null)
                {
                    pizza.Prepare();
                    pizza.Bake();
                    pizza.Cut();
                    pizza.Box();
                }
                else
                {
                    Console.WriteLine("没有");
                    break;
                }

            } while (true);
        }

        public string GetOrderType()
        {
            Console.WriteLine("种类");
            string k = Console.ReadLine();
            return k;
        }
    }
}
