using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2Lesson
{
    partial class Program
    {
        static void Task5()
        {
            Console.Clear();
            Console.WriteLine("Задание 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме\n" +
                "б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.\n");
            Console.WriteLine("Введите ваш вес, кг");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост, см");
            double h = double.Parse(Console.ReadLine())/100;
            double I = m / (h * h);
            double idealImin = 18.5;
            double idealImax = 24.99;
            double deltaM = 0;
            Console.WriteLine("\nВаш индекс массы тела - {0:F2}", I);

            if (I <= 18.49)
            {
                Console.WriteLine("\nа) Ваш индекс говорит о дефиците массы тела. Рекомендуется лучше кушать жирного и сладкого.");
                double minM = idealImin * (h * h);
                deltaM = minM - m;
                Console.WriteLine("б) Для нормализации веса необходимо набрать {0:F2}" + " кг.\n", deltaM);
            }
            else if (I >= 25)
            {
                Console.WriteLine("\nа) Ваш индекс говорит о " + '\u0022' + "небольшом" + '\u0022' + " ожирении. Рекомендуется жрать поменьше, а работать побольше.");
                double maxM = idealImax * (h * h);
                deltaM = m - maxM;
                Console.WriteLine("б) Для нормализации веса необходимо сбросить {0:F2}" + " кг.\n", deltaM);
            }
            else
            {
                Console.WriteLine("\nа) Ваш индекс говорит о том, что ты красавчик!");
                Console.WriteLine("б) Вах! Ничего не надо делать, дорогой!");
            }

            Console.WriteLine("\nНажмите кнопку \"Пробел\" для повтора этого решения или любую другую для возврата к выбору задания");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
               Task5();
            }
            else return;
        }
    }
}
