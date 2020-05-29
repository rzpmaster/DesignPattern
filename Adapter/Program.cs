using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //类适配器
            Phone phone = new Phone();
            //phone.Charging(new VoltageAdapter());

            //对象适配器
            phone.Charging(new VoltageAdapter2(new Voltage220()));

            Console.ReadLine();
        }
    }
}
