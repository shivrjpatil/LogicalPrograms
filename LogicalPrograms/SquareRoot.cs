using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SquareRoot
    {
        public double Root(double n, double l)
        {
            double x = n;
            double root;
            int count = 0;
            while (true)
            {
                count++;
                root = 0.5 * (x + (n / x));
                if (Math.Abs(root - x) < 1)
                    break;
                    x = root;
            }
            return root;
        }
       
    }
}
