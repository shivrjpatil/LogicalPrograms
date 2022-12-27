using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class VendingMachine
    {
        public void Vending()
        {
            int total = 0, rem = 0;
            Console.WriteLine("Enter the Amount");
            int Amount = Convert.ToInt32(Console.ReadLine());

            int[] Cash = {1000,500,100,50,10,5,2,1 };
            for (int i = 0; i < Cash.Length; i++)
            {

                if (Amount >= Cash[i])
                {
                    int calNotes = Amount / Cash[i];
                    rem = Amount % Cash[i];
                    Amount = rem;
                    total += calNotes;
                   Console.WriteLine(Cash[i] + " Notes ---> " + calNotes);
                }
            }   
        }
    }
}
