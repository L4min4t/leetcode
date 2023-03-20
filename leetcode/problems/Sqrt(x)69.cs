using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{
    internal class Sqrt_x_69
    {
        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            double n0 = x / 2.0;
            while (true) {
                double ni = (n0 + x / n0) / 2;
                if (Math.Abs(ni - n0) < 0.01) return (int) ni;
                n0 = ni;
            }
            
        }
    }
}
