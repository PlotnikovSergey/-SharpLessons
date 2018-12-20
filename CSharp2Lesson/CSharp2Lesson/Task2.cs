using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2Lesson
{
    partial class Program
    {
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Задание 2. Написать метод подсчета количества цифр числа.\n\nВведите целое число:\n");
            string One = "";
            String inputString = Console.ReadLine();
            // Вариант 1: Считаем количество символов в числе
            int numbersAmount = inputString.Length;
            if (numbersAmount == 1)
            {
                One = "цифра";
            }
            else if (numbersAmount > 4)
            {
                One = "цифр";
            }
            else
            {
                One = "цифры";
            }
            Console.WriteLine("Вариант 1: В числе " + '\u0022' + inputString+ '\u0022' + " - " + numbersAmount + " "+ One+ "\n");

            // Вариант 2: Делим число на 10, как в уроке
            UInt64 inputNumber = UInt64.Parse(inputString);
            int i = 0;
            while (inputNumber != 0)
            {
                i++;
                inputNumber /= 10;
            }
            if (i == 1)
            {
                One = "цифра";
            }
            else if (i > 4)
            {
                One = "цифр";
            }
            else
            {
                One = "цифры";
            }
            Console.WriteLine("Вариант 2: В числе " + '\u0022' + inputString + '\u0022' + " - " + i + " " + One);
            // К сожалению не понял, как корректно вызывать метод, определяющий окончание у "цифр" из другого метода, прошлось проверку 2 раза прописать :(

            Console.WriteLine("\nНажмите кнопку \"Пробел\" для повтора этого решения или любую другую для возврата к выбору задания");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                Task2();
            }
            else return;
        }
    }
}
