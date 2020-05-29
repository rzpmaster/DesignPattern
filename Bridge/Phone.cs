using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Phone
    {
        private Brand brand;

        public Phone(Brand brand)
        {
            this.brand = brand;
        }

        public void Open()
        {
            brand.Open();
        }

        public void Close()
        {
            brand.Close();
        }

        public void Call()
        {
            brand.Call();
        }
    }
}
