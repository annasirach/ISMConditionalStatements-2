using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0, n;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                s += n;
            }
            while (n != 0);
            Console.WriteLine("Сума = {0:F0}", s);
        }
    }
}
