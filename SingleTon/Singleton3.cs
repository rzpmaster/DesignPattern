using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    /// <summary>
    /// 内部类 线程安全
    /// </summary>
    class Singleton3
    {

        private Singleton3()
        {
        }

        public static Singleton3 GetInstance()
        {
            return Nested.instance;
        }

        private class Nested
        {
            // 显式静态构造告诉C＃编译器
            // 未标记类型BeforeFieldInit
            static Nested()
            {
            }

            internal static readonly Singleton3 instance = new Singleton3();
        }
    }

}
