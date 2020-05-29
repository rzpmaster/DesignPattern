using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Department: OrganizationComponent
    {
        public Department(string name, string des) : base(name, des)
        {
        }

        public override void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
