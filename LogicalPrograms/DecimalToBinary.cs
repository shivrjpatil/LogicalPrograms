using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class DecimalToBinary
    {
        public void ToBinary()
        {
            int i;
            Console.WriteLine("Enter the NUmber ");
            int num =Convert.ToInt32(Console.ReadLine());

            int[] Binary = new int[8];
            for (i = 0; i < Binary.Length; i++)
            {
                Binary[i] = num % 2;
                int a = num / 2;
                num = a;
            }
                for( i = i-1; i >= 0; i--)
                {
                    Console.Write(Binary[i]);
                }            
        }
    }
}
