using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 1, s = 0;
            Console.Write("N=");
            double n = Convert.ToInt32(Console.ReadLine());
            for (double i = n; i >= 1; i--)
            {
                s = s + Math.Pow(num, i);
                num++;
            }
            Console.WriteLine("Результат = {0:F0}", s);
        }
    }
}
