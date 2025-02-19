using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        private double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divider cannot be zero");
            return (double)a / b;
        }
    }
}
