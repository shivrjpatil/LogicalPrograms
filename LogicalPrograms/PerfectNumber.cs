using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            int sum = 0;
            Console.WriteLine("Enter the Number");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
                if (sum == num)
                    Console.WriteLine("the number is perfect number ");
                else
                    Console.WriteLine("the number is not perfect number");
            
        }
    }
}
