using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2Lesson
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
                Console.WriteLine("Урок 2. Плотников Сергей.");
                Console.WriteLine("Нажмите соответствующую клавишу для вывода решения или выхода из программы.\n");
                Console.WriteLine("1 - Задание 1\n2 - Задание 2\n3 - Задание 3\n4 - Задание 4\n5 - Задание 5\n6 - Задание 6\n7 - Задание 7\n0 - Выход");
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Program.Task1();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Program.Task2();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Program.Task3();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Program.Task4();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Program.Task5();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        Program.Task6();
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        Program.Task7();
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
