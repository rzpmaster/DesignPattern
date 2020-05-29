using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(new SimpleFactory());
            order.CreateGoods();

            Console.ReadLine();
        }
    }
}
