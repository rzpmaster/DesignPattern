using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //抽象的建造者
    public abstract class HouseBuilder
    {
        protected House house = new House();

        //建造者的流程
        public abstract void BuildBasie();
        public abstract void BuildWalls();
        public abstract void Roofed();

        //建造房子，将房子返回
        public House Build()
        {
            return house;
        }

    }
}
