using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Phone
    {
        public void Charging(IVoltage5 voltage5)//接口中放的Adapters
        {
            if (voltage5.Output5V()==5)
            {
                Console.WriteLine("电压合适，可以充电");
            }
            else
            {
                Console.WriteLine("电压过高，无法充电");
            }
        }
    }
}
