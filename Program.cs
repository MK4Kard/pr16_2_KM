using System;
using System.Linq;
using System.Collections.Generic;

namespace pr16_3_KM
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();

                Console.WriteLine("Введите длину массива");
                int n = Convert.ToInt32(Console.ReadLine());

                double[] arr = new double[n];

                Console.WriteLine("Массив");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Math.Round(rnd.NextDouble() * (11 - 0) + 0, 1);

                    Console.Write($"{arr[i]} ");
                }

                Console.WriteLine();
                Console.WriteLine("Число-Частота");
                var unq = arr.GroupBy(x => x). // группировка по одинаковым значениям
                    Select(group => new { N = group.Key, Count = group.Count() }); // создание объекта, содержащего значение элемента и его количество
                foreach (var item in unq)
                {
                    Console.WriteLine($"{item.N}-{item.Count}");
                }

                Console.WriteLine("Число-Частота(старого массива)");
                foreach (var item in unq)
                {
                    Console.WriteLine($"{item.N * item.Count}-{item.Count}");
                }
            }
            catch
            {
                Console.WriteLine("Неверное значение");
            }
        }
    }
}
