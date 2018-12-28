using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5Lesson
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Урок 5. Плотников Сергей.");
                Console.WriteLine("Нажмите соответствующую клавишу для вывода решения или выхода из программы.\n");
                Console.WriteLine("1 - Задание 1\n2 - Задание 2\n0 - Выход");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Task1();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Task2();
                        break;
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                    case ConsoleKey.Escape:
                        Console.WriteLine("Программа завершена!");
                        return;
                    default:
                        Console.WriteLine("Нажмите кнопку, согласно подсказке");
                        break;
                }
            }
            while (true);
        }
    }
}
