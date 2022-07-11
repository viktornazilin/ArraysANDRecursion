// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2-> 2
// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; 5,5)

using System;

namespace ArraysANDRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 41
            Console.Write("Задача 41");
            Console.Write("Задайте числа через пробел: ");
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Checking(input);

            //Задача 43
            Console.Write("Задача 43");
            Console.Write("Введите k1: ");
            var k1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b1: ");
            var b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите k2: ");
            var k2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите b2: ");
            var b2 = Convert.ToDouble(Console.ReadLine());
            Lines(k1, b1, k2, b2);

        }

        static void Checking(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество элементов больше 0: {count}");
        }

        static void Lines(double k1, double b1, double k2, double b2)
        {
            var x = -(b1 - b2) / (k1 - k2);
            var y = k1 * x + b1;

            if (k1 == k2 && b1 == b2)
            {
                Console.WriteLine("Отрезки имеют одинаковые координаты");
            }
            else
            {
                x = Math.Round(x, 3);
                y = Math.Round(y, 3);

                Console.WriteLine($"Пересечение в точке: ({x} ; {y})");
            }

            
        }

    }
}