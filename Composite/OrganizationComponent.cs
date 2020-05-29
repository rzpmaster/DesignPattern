using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class OrganizationComponent
    {
        public OrganizationComponent(string name,string des)
        {
            Name = name;
            Description = des;
            organizationComponents = new List<OrganizationComponent>();
        }
        public abstract void Print();

        public string Name { get; set; }
        private string Description { get; set; }

        public List<OrganizationComponent> organizationComponents;
    }
}
