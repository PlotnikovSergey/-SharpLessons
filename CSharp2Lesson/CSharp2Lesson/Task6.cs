using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2Lesson
{
    partial class Program
    {
        static void Task6()
        {
            Console.Clear();
            Console.WriteLine("Задание 6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму " +
                "своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.\n");
            long startLong = DateTime.Now.Ticks;
            int index = 9;
            for (int i = 10; i < 1000000000; i++)
            {
                int sumOfNumbers = countDigits(i);
                //Console.WriteLine("Сумма цифр " + i + " " + sumOfNumbers);
                if (i%sumOfNumbers == 0)
                  {
                     index++;
                  }
            }
            long endLong = DateTime.Now.Ticks;
            double time = (endLong - startLong)/10000000.0;
            Console.WriteLine("Количество хороших чисел " + index);
            Console.WriteLine("Время выполнения программы, сек. {0:F2}", time);

            int countDigits(int N)
            {
                int s = 0;
                while (N > 0)
                {
                    s += N%10;
                    N /= 10;
                }
                return s;
            }


            Console.WriteLine("\nНажмите кнопку \"Пробел\" для повтора этого решения или любую другую для возврата к выбору задания");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                Task6();
            }
            else return;
        }
    }
}
