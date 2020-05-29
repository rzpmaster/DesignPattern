using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //产品类 Product
    public class House
    {
        public string Basie { get; set; }
        public string Wall { get; set; }
        public string Roof { get; set; }

        public override string ToString()
        {
            return string.Format("地基：{0}\t墙：{1}\t屋顶：{2}", Basie, Wall, Roof);
        }
    }
}
