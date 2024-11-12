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
            EvenTwoDigitNumbers();

            // Создание новой переменной через метод
            int x = NewInteger("x");

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

        // Метод для создания новой переменной
        public static int NewInteger(string name)
        {
            Console.Write($"Значение переменной {name}: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
