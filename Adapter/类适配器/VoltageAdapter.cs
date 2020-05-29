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
    public class VoltageAdapter : Voltage220, IVoltage5
    {
        public int Output5V()
        {
            int src = Output220V();
            int dst = src / 44;
            return dst;
        }
    }
}
