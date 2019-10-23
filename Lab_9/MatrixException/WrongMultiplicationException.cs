using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixException
{
    public class WrongMultiplicationException : Exception
    {
        public WrongMultiplicationException(string message = "Некорректное умножение.") : base(message)
        {
        }
    }
}
