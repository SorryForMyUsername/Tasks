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
            int x1 = NewInteger("x1");
            int y1 = NewInteger("y1");
            int x2 = NewInteger("x2");
            int y2 = NewInteger("y2");
            int x3 = NewInteger("x3");
            int y3 = NewInteger("y3");

            double square = TriangleSquare(SideLength(x1, y1, x2, y2), SideLength(x1, y1, x3, y3), SideLength(x3, y3, x2, y2));
            double perimeter = TrianglePerimeter(SideLength(x1, y1, x2, y2), SideLength(x1, y1, x3, y3), SideLength(x3, y3, x2, y2));

            Console.WriteLine($"Площадь треугольника: {square:N2}\nПериметр треугольника: {perimeter:N2}");

            Console.ReadKey();
        }

        public static int NewInteger(string name)
        {
            Console.Write($"{name} = ");
            return int.Parse(Console.ReadLine());
            
        }

        public static double SideLength(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double TriangleSquare(double side1, double side2, double side3)
        {
            if(side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
            {
                Console.WriteLine("Такого треугольника не существует");
                return 0;
            }
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public static double TrianglePerimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }
    }
}
