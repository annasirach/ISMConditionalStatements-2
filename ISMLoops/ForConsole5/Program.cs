using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1,s=0;
            Console.Write("N:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                p *= i;
                s += p;
            }
            Console.WriteLine("s = {0}", s);
        }
    }
}
