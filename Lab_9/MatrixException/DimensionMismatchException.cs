using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixException
{
    public class DimensionMismatchException : Exception
    {
        public DimensionMismatchException(string message = "Несовпадение размерностей.") : base(message)
        {
        }
    }
}
