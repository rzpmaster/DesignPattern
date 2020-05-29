using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    /// <summary>
    /// 饿汉式 静态常量
    /// </summary>
    /// <remarks>
    /// 缺点
    /// 在类装载的时候就实例化，避免了多线程同步
    /// 可用，可能造成内存浪费
    /// </remarks>
    public class Singleton1
    {
        private static Singleton1 Instance=new Singleton1();
        private Singleton1()
        {

        }

        public static Singleton1 GetInstance()
        {
            return Instance;
        }
    }
}
