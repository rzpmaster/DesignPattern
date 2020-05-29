using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface IComponent<T> where T: OrganizationComponent
    {
        void Add(T component);
        void Remove(T component);
    }
}
