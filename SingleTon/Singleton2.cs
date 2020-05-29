using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    /// <summary>
    /// 懒汉式
    /// </summary>
    class Singleton2
    {
        private static Singleton2 Instance;
        private Singleton2()
        {

        }

        public static Singleton2 GetInstance()
        {
            if (Instance==null)//糟糕代码，多线程不安全
            {
                Instance = new Singleton2();
            }
            return Instance;
        }

        //
        //改进
        //

        private static readonly object padlock = new object();
        public static Singleton2 GetInstance2()
        {
            lock (padlock)//线程安全，但是效率太低
            {
                if (Instance == null)
                {
                    Instance = new Singleton2();
                }
            }
            return Instance;
        }

        public static Singleton2 GetInstance3()
        {
            if (Instance == null)
            {
                lock (padlock)//线程安全，懒加载
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton2();
                    }
                } 
            }
            return Instance;
        }
    }
}
