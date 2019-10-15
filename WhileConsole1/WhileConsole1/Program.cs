using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            double n = Convert.ToInt32(Console.ReadLine());
            double a = 0, i = 0;
            while (a <= n)
            {
                i++;
                a = Math.Pow(3, i);

            }
            Console.WriteLine("Результат = {0:F0}", i);
        }
    }
}
