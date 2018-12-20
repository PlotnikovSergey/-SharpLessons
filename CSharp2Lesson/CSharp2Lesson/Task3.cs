using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2Lesson
{
    partial class Program
    {
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Задание 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.\n");
          //  Console.WriteLine("Введите целое число:");
            int input = 0;
            int n = 0;
            do
            {
                Console.WriteLine("Введите целое число:");
                Int32 inp = Int32.Parse(Console.ReadLine());
                input = inp;
                if (input > 0 && input%2 != 0)
                {
                    n++;
                }
            }
            while (input != 0);

            Console.WriteLine("\nСреди введенных чисел- " + n + " положительных нечетных.");

            Console.WriteLine("\nНажмите кнопку \"Пробел\" для повтора этого решения или любую другую для возврата к выбору задания");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                Task3();
            }
            else return;
        }
    }
}
