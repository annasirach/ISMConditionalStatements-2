using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum=1;
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=2;i<=n;i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine("Summa = {0}", sum);
        }
    }
}
