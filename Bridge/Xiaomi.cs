using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Xiaomi : Brand
    {
        public void Call()
        {
            Console.WriteLine("小米手机打电话");
        }

        public void Close()
        {
            Console.WriteLine("小米手机关机");
        }

        public void Open()
        {
            Console.WriteLine("小米手机开机");
        }
    }
}
