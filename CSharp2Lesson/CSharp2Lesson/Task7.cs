using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2Lesson
{
    partial class Program
    {
        static void Task7()
        {
            Console.Clear();
            Console.WriteLine("Задание 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b); б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.\n");

            Console.WriteLine("Введите первое целое число");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Recursion(a, b));
 
            Console.WriteLine("\nНажмите кнопку \"Пробел\" для повтора этого решения или любую другую для возврата к выбору задания");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                Task7();
            }
            else return;
        }

        static String Recursion(int n, int m)
        {
            return n + " " + Recursion(n + 1, m); //Не осилил я этот StackoverFlow!
        }
    }
}
