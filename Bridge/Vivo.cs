using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Vivo : Brand
    {
        public void Call()
        {
            Console.WriteLine("Vivo手机打电话");
        }

        public void Close()
        {
            Console.WriteLine("Vivo手机关机");
        }

        public void Open()
        {
            Console.WriteLine("Vivo手机开机");
        }
    }
}
