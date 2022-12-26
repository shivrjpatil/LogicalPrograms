using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class TempratureConversion
    {

        public void Celsius()
        {
            Console.WriteLine("Enter Temprature in celsius");
            double deg=Convert.ToDouble(Console.ReadLine());
            double Farenhit = (deg * (1.8) + 32);
            Console.WriteLine("the {0} Celsius = {1} Farenhit",deg,Farenhit);
        }
        public void Farenhit()
        {
            Console.WriteLine("Enter Temprature in Farenhit");
            double deg = Convert.ToDouble(Console.ReadLine());
            double Celsius = (deg - 32) * 5 / 9;
            Console.WriteLine("the {0} Farenhit = {1} Celsius",deg,Celsius);
        }
    }
}
