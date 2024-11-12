using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум
{
    class Program
    {
        static void Main(string[] args)
        {
            Func(-5, 5, 2);

            Console.ReadKey();
        }

        public static void Func(int startValue, int endValue, int step)
        {
            for(int x = startValue; x <= endValue; x += step)
            {
                double y = 5 * Math.Pow(x, 2) - 2 * x + 1;
                Console.WriteLine($"y({x}) = {y}");
            }
        }
    }
}
