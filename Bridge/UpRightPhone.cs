using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class UpRightPhone:Phone
    {
        public UpRightPhone(Brand brand):base(brand)
        {

        }

        public new void Open()
        {
            Console.WriteLine("直立手机");
            base.Open();
        }

        public new void Close()
        {
            Console.WriteLine("直立手机");
            base.Close();
        }
        public new void Call()
        {
            Console.WriteLine("直立手机");
            base.Call();
        }
    }
}
