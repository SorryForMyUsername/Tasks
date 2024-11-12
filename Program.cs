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
            //EvenTwoDigitNumbers();

            int x = NewInteger();

            Console.ReadKey();
        }

        public static void EvenTwoDigitNumbers()
        {
            int count = 0;
            for(int twoDigitNumber = 10; twoDigitNumber < 100; twoDigitNumber++)
            {
                if(twoDigitNumber % 2 == 0)
                {
                    Console.WriteLine(twoDigitNumber);
                    count++;
                }
            }
            Console.WriteLine($"Кол-во чётных двухзначных чисел: {count}");
        }

        public static int NewInteger()
        {
            Console.Write("Значение новой переменной: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
