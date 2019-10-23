using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class ProductDiscaunt25 : Product
    {
        public ProductDiscaunt25(string name, double price) : base(name, price)
        {
            this.price = price * 0.75;
        }
    }
}
