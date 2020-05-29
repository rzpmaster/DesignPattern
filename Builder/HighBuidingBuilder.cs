using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HighBuidingBuilder : HouseBuilder
    {
        public override void BuildBasie()
        {
            house.Basie = "100m";
            Console.WriteLine("高楼打地基  100m");
        }

        public override void BuildWalls()
        {
            house.Wall = "20cm";
            Console.WriteLine("高楼砌墙  20cm");
        }

        public override void Roofed()
        {
            house.Roof = "高楼屋顶  透明屋顶";
            Console.WriteLine("高楼屋顶  透明屋顶");
        }
    }
}
