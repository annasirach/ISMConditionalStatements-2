using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("P=");
            double p = Convert.ToInt32(Console.ReadLine());
            double s = 10, d = 10, k = 1; ;
            while (s < 200)
            {
                d = d + d * (p / 100);
                s = s + d;
                k++;
            }
            Console.WriteLine("Кількість днів = {0:F0}", k);
            Console.WriteLine("Пробіг = {0:F2}", s);
        }
    }
    
}
