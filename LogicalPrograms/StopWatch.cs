using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatcher
    {
        public void satrtstop()
        {
            Stopwatch stop = new Stopwatch();
            stop.Start();
            Random random = new Random();
            int randomNum = random.Next(1,100);
            int a=randomNum;
            int b=randomNum;
            while (a  != 100)
            {
                a += b;
            }
            stop.Stop();

            Console.WriteLine("Elapsed time"+stop.ElapsedMilliseconds);
               
           
        }
    }
}
