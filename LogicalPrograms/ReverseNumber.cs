using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            int Rem = 0, Reverse = 0;
            Console.WriteLine("Enter the Number");
            int num =Convert.ToInt32(Console.ReadLine());
            while(num!=0)
            {
                Rem = num % 10;
                Reverse = Reverse * 10 + Rem;
                num = num / 10;
            }
            Console.WriteLine("Reverse Number:"+Reverse);
        }
            
    }
}
