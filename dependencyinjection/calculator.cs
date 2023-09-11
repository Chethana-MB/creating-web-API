using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjection
{
    internal class calculator
    {
        int d;
        public calculator(int k)
        {
            d = k;
        }
        public int add(int x, int y)
        {
            return x + y;
        }
        public int substract(int x, int y)
        {
            return x - y;
        }
    }
}
