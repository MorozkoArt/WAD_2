using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA2
{
    internal class Sin : IFunction
    {
        public double calc(double x)
        {
            return (Math.Sin(x));
        }
    }
}
