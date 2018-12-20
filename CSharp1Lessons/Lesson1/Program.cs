// Решение задач к уроку 1. Плотников Сергей.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static String result1="";
        static String result2;
        static int k = 0;
        static String city;

        static void PrintOnCenter(string message)
        {
            Console.SetCursorPosition((Console.WindowWidth / 2), Console.WindowHeight / 2);
            Console.WriteLine(message);
        }

        static void PrintAndInput(string message)
        {
        Console.WriteLine("Введите " + message);
          string input = Console.ReadLine();
          result1 = result1+ " " + message + " " + input;     // склеиваем результирующий вывод   
          result2 = input;
        }
        static void Print(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            // Задание 1 Анкета -------------------------------------------------------------------------------------------------------
            Print("Плотников Сергей.\n Задание 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:\n а) используя  склеивание;\n б) используя форматированный вывод;\nв) используя вывод со знаком $\n");

            String[] personalParameters = { "имя", "фамилия", "возраст(полных лет)", "рост (метры,сантиметры)", "вес(кг,грамм)" };
            String[] answers = { "", "", "", "", "" };

            foreach (String i in personalParameters)
            {
                PrintAndInput(i);
                answers[k] = result2;
                k++;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Print("Выводим \"склеенный\" вывод:");
            Console.WriteLine(result1);     // выводим "склеенный" вывод
            Console.ForegroundColor = ConsoleColor.Red;
            Print("Выводим \"форматированный\" вывод:");
            Console.WriteLine("Имя {0, 1}, Фамилия {1, 1}, Возраст {2, 1} лет, Рост {3, 1} м, Вес {4, 1} кг", answers[0], answers[1], answers[2], answers[3], answers[4]); //выводим форматированный вывод
            Console.ForegroundColor = ConsoleColor.Green;
            Print("Выводим вывод с $:");
            Console.WriteLine($"Имя {answers[0],1}, Фамилия {answers[1],1}, Возраст {answers[2],1} лет, Рост {answers[3],1} м, Вес {answers[4],1} кг");
            Print("\n");
            Console.ReadLine();
            Console.Clear();

            // Задание 2 - Расчет индекса массы тела (данные по массе и росте взяты из задания 1) -------------------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.White;
            Print("Задание 2\nВвести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.");
            Console.WriteLine(answers[0] + ", рассчитаем ваш индекс массы тела, на основании ранее введенных значений массы и роста");
            double m = double.Parse(answers[4]);
            double h = double.Parse(answers[3]);
            double I = m / (h * h);
            Console.WriteLine(answers[0] + ", ваш индекс массы тела - {0:F2}", I);
            Print("\n");
            Console.ReadLine();
            Console.Clear();

            // Задание 3 - Расстояние между точками ---------------------------------------------------------------------------------------------------------------------------------------
            Print("Задание 3\nа) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).\n");
            Print("Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой)");
            Print("б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.");
            double Ranger(double coordx1, double coordy1, double coordx2, double coordy2)
            {
                return Math.Sqrt(Math.Pow(coordx2 - coordx1, 2) + Math.Pow(coordy2 - coordy1, 2));
            }
            double x1 = 0, y1 = 0, x2 = 10, y2 = 30;
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Координаты x1={0},  y1={1}, x2={2}, y2={3}. Расстояние между точками ={4:F2}", x1, y1, x2, y2, r);
            Print("\n");
            Console.WriteLine("Вызов метода");
            Console.WriteLine("Координаты x1 ={0},  y1 ={1}, x2 ={2}, y2 ={3}. Расстояние между точками ={4:F2}", x1, y1, x2, y2, Ranger(x1, y1, x2, y2));
            Print("\n");
            Console.ReadLine();
            Console.Clear();

            //Задание 4 - Обмен значениями переменных -------------------------------------------------------------------------------------------------------------------------------------
            Print("Задание 4\nНаписать программу обмена значениями двух переменных:\nа) с использованием третьей переменной;\nб) *без использования третьей переменной.");
            int x = 1;
            int y = 3;
            Console.WriteLine("x = " + x + "\nу = " + y);
            int c = x;
            x = y;
            y = c;
            Console.WriteLine("\nИспользуя третью переменную:\nx = " + x + "\nу = " + y);
            //x = x + y;
            //y = x - y;
            //x = х - y; name x does not exist in current context  - не работает
            x = 1;
            y = 3;
            y = x + y;
            x = y - x;
            y = y - x;
            Console.WriteLine("\nНе используя третью переменную:\nx = " + x + "\nу = " + y);
            Console.ReadLine();
            Console.Clear();

            // Задание 5 Вывод данных в разных областях экрана --------------------------------------------------------------------------------------------------------------------------------------
            Print("Задание 5\nа) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.\nб) *Сделать задание, только вывод организовать в центре экрана.\nв) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).\n");
            Console.WriteLine(answers[0] + ", введите город проживания: ");
            city = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Print("Вывод по умолчанию:");
            Print(answers[0] + " " + answers[1] + " " + city + "\n");
            Print("Вывод по центру:");
            Console.SetCursorPosition((Console.WindowWidth / 2), Console.WindowHeight / 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(answers[0] + " " + answers[1] + " " + city);
            Print("Нажмите \"Ввод/Enter\" для вызова метода");
            Console.ReadLine();
            Console.Clear();
            PrintOnCenter("Пишу по центру");
            Console.ReadLine();
        }          
    }
    //Задание 6 Создать класс с методами
    class ConsoleManipulation
    {
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        static void Clear()
        {
            Console.Clear();
        }
        static void Pause(int n)
        {
            for (int i= 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                { 
                }
            }
        }
    }
}
