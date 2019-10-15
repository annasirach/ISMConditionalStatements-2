using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            Console.Write("A= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B= ");
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i=a; i<=b;i++)
            {
                c *= i;
            }
            Console.WriteLine("Результат = {0}", c);
        }
    }
}
