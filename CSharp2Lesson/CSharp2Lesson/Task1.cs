using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2Lesson
{
    partial class Program
    {
         
        static void Task1()
        {
                Console.Clear();
                Console.WriteLine("Задание 1. Написать метод, возвращающий минимальное из трех чисел.\n");
                Double x, y, z, min;
                Console.WriteLine("Введите первое число.");
                x = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число.");
                y = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите третье число.");
                z = Double.Parse(Console.ReadLine());
                if (x < y)
                {
                    min = x;
                }
                else
                {
                    min = y;
                }
                if (z < min)
                {
                    min = z;
                }
                Console.WriteLine("\nМинимальным числом из " + x + ", " + y + ", " + z + ", является число " + min + "\n");

                Console.WriteLine("\nНажмите кнопку \"Пробел\" для повтора этого решения или любую другую для возврата к выбору задания");
                ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                    Task1();
                    }
                    else return;
         }
    }
}
