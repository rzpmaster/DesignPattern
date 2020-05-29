using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CommonHouseBuilder : HouseBuilder
    {
        public override void BuildBasie()
        {
            house.Basie = "5m";
            Console.WriteLine("普通房子打地基  5m");
        }

        public override void BuildWalls()
        {
            house.Wall = "10cm";
            Console.WriteLine("普通房子砌墙  10cm");
        }

        public override void Roofed()
        {
            house.Roof = "普通房子屋顶";
            Console.WriteLine("普通房子屋顶");
        }
    }
}
