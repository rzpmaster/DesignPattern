using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        //桥接模式：父类聚合一个接口，子类调用接口的方法
        static void Main(string[] args)
        {
            FoldePhone foldePhone = new FoldePhone(new Xiaomi());
            foldePhone.Open();
            foldePhone.Close();
            foldePhone.Call();

            UpRightPhone upRightPhone = new UpRightPhone(new Vivo());
            upRightPhone.Open();
            upRightPhone.Close();
            upRightPhone.Call();

            Console.ReadLine();
        }
    }
}
