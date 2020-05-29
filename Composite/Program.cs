using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// 组合模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //从大到小创建
            University university = new University("南昌大学", "中国一般的大学");

            College college1 = new College("资源环境与化学工程学院", "");
            College college2 = new College("计算机工程学院", "");

            college1.Add(new Department("环境工程", "很垃圾"));
            college1.Add(new Department("环境科学", "也很垃圾"));

            college2.Add(new Department("软件工程", "还不错"));
            college2.Add(new Department("网络工程", "也还行"));

            university.Add(college1);
            university.Add(college2);

            college2.Print();
            university.Print();


            Console.ReadLine();
        }
    }
}
