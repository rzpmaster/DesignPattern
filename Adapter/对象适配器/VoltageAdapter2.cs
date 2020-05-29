using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 类适配器
    /// </summary>
    public class VoltageAdapter2 :IVoltage5
    {
        private Voltage220 voltage220;

        public VoltageAdapter2(Voltage220 voltage220)
        {
            this.voltage220 = voltage220;
        }

        public int Output5V()
        {
            int dst = 0;
            if (null!=voltage220)
            {
                int src = voltage220.Output220V();
                dst = src / 44;
                Console.WriteLine("适配完成");
            }
            return dst;
        }
    }
}
