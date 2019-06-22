using System;
using static System.Console;
namespace _01_Csharp_introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Дано значение температуры T в градусах Фаренгейта. Определить значение этой же температуры в градусах Цельсия. Температура 
            //по Цельсию TC и температура по Фаренгейту TF связаны следующим соотношением: TC = (TF – 32)·5/9.

            WriteLine("Enter farenhaite temperature");
            double tf = double.Parse(ReadLine());
            WriteLine($"Celsium temperature is {(tf - 32) * 5 / 9:f2}");

            //2. Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь, используя формулу для 
            //расстояния между двумя точками на плоскости
            //Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона: 
            //S = (p·(p – a)·(p – b)·(p – c))1/2,
            //где p = (a + b + c) / 2 — полупериметр.

            WriteLine("Enter coordinate x1");
            double x1 = double.Parse(ReadLine());
            WriteLine("Enter coordinate y1");
            double y1 = double.Parse(ReadLine());
            WriteLine("Enter coordinate x2");
            double x2 = double.Parse(ReadLine());
            WriteLine("Enter coordinate y2");
            double y2 = double.Parse(ReadLine());
            WriteLine("Enter coordinate x3");
            double x3 = double.Parse(ReadLine());
            WriteLine("Enter coordinate y3");
            double y3 = double.Parse(ReadLine());
            double side1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double side2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double side3 = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            double p = (side1 + side2 + side3) / 2;
            WriteLine($"The perimeter of triangle is {p * 2:f2}");
            WriteLine($"The square of triangle is {Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)):f2}");
        }
    }
}
