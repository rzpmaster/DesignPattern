using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Voltage220
    {
        public int Output220V()
        {
            int src = 220;
            Console.WriteLine("电压"+src+"V");
            return src;
        }
    }
}
