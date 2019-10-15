using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 1;
            Console.Write("A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                res *= a;
            }
            Console.WriteLine("Result = {0}", res);
        }
    }
}
