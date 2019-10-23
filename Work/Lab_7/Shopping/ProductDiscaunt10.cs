using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class ProductDiscaunt10 : Product
    {
        public ProductDiscaunt10(string name, double price) : base(name, price)
        {
            this.price = price * 0.9;
        }
    }
}
