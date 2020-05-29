using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class FoldePhone : Phone
    {
        public FoldePhone(Brand brand):base(brand)
        {
        }

        public  void Open()
        {
            Console.WriteLine("折叠手机");
            base.Open();
        }

        public  void Close()
        {
            Console.WriteLine("折叠手机");
            base.Close();
        }
        public  void Call()
        {
            Console.WriteLine("折叠手机");
            base.Call();
        }
    }
}
