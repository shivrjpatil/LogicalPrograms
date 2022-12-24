using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Logical Programs");
            
            FibonacciSeries series = new FibonacciSeries();
            series.Fibonacci();
            Console.ReadLine();
        }
    }
}
