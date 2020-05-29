using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton3 singleton1_1 = Singleton3.GetInstance();
            Singleton3 singleton1_2 = Singleton3.GetInstance();

            Console.WriteLine(singleton1_1 == singleton1_2);
            Console.WriteLine(singleton1_1.GetHashCode());
            Console.WriteLine(singleton1_2.GetHashCode());

            Console.ReadLine();
        }
    }
}
