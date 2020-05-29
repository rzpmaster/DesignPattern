using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        //客户端，调用
        static void Main(string[] args)
        {
            Console.WriteLine("普通房子");
            //准备普通房子
            CommonHouseBuilder commonHouse = new CommonHouseBuilder();//建造者
            //创建一个指挥者
            HouseDirector houseDirector = new HouseDirector(commonHouse);
            //完成房子
            House house = houseDirector.ConstructHouse();
            Console.WriteLine(house.ToString());
            Console.WriteLine();

            Console.WriteLine("高楼");
            //准备高楼
            HighBuidingBuilder highBuiding = new HighBuidingBuilder();
            //重置指挥者
            houseDirector.SetHouseBuilder(highBuiding);
            //完成高楼
            House house1 = houseDirector.ConstructHouse();
            Console.WriteLine(house1.ToString());

            StringBuilder

            Console.ReadLine();
        }
    }
}
