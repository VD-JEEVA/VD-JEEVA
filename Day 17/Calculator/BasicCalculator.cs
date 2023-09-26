using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class BasicCalculator
    {
        public int add(int x, int y) { return x + y; }

        //public T add<T>(T x, T y)
        //{
  
        //}

        public int subtract(int x, int y) { return x - y; }

        public int multiply(int x, int y) { return y * x; }

        public int divide(int x, int y) { 
            
            if(y == 0)
            {
                throw new ArgumentException("Hey, you entered zero... Check with the arguments you passed in divide() method");
            }
            return x / y;
        }
    }
}
