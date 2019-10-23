using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class ProductDiscaunt50 : Product
    {
        public ProductDiscaunt50(string name, double price) : base(name, price)
        {
            this.price = price * 0.5;
        }
    }
}
