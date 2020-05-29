using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //指挥者，动态指定制作流程
    public class HouseDirector
    {
        HouseBuilder houseBuilder = null;

        //通过构造器传入建造者
        public HouseDirector(HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        //改变建造者
        public void SetHouseBuilder(HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        //如何建造房子，交给指挥者
        public House ConstructHouse()
        {
            houseBuilder.BuildBasie();
            houseBuilder.BuildWalls();
            houseBuilder.Roofed();

            return houseBuilder.Build();
        }
    }
}
