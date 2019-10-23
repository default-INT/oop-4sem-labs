using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixException
{
    public class IncorrectMatrixException : Exception
    {
        public IncorrectMatrixException(string message = "Некорректная матрица.") : base(message)
        {
        }
    }
}
