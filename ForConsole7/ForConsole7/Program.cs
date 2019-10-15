using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            Console.Write("N=");
            double n = Convert.ToInt32(Console.ReadLine());
            Console.Write("K=");
            double k = Convert.ToInt32(Console.ReadLine());
            for (double i = 1; i <= n; i++)
            {
                s+= Math.Pow(i, k);
            }
            Console.WriteLine("Результат = {0:F0}", s);
        }
    }
}
