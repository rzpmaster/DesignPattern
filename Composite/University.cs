using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class University : OrganizationComponent,IComponent<College>
    {
        public University(string name, string des) : base(name, des)
        {
        }

        public void Add(College component)
        {
            organizationComponents.Add(component);

        }

        public void Remove(College component)
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
