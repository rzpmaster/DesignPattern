using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class College: OrganizationComponent,IComponent<Department>
    {
        public College(string name, string des) : base(name, des)
        {
        }

        public void Add(Department component)
        {
            organizationComponents.Add(component);
        }

        public void Remove(Department component)
        {
            organizationComponents.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("===========" + Name + "===========");
            foreach (var item in organizationComponents)
            {
                item.Print();
            }
        }
    }
}
