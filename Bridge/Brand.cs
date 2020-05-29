using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //品牌接口
    public interface Brand
    {
        void Open();
        void Close();
        void Call();
    }
}
