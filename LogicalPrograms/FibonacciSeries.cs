using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
        {
            Console.WriteLine("Enter the Number");
            int num=Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i = 0; i <= num; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;                
            }
           
        }
    }
}
