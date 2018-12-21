using System;

namespace CSharp3Lesson
{
    partial class Program
    {
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Задание 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. " +
                "Сами числа и сумму вывести на экран, используя tryParse; б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки " +
                "вывести сообщение.Напишите соответствующую функцию;\n");

            int input = 0;
            int n = 0;
            
            do
            {
                Console.WriteLine("Введите целое число:");
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректные данные!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Введите целое число:");
                }
                if (input > 0 && input % 2 != 0)
                {
                    n++;
                }
            }
            while (input != 0);

            Console.WriteLine("\nСреди введенных чисел- " + n + " положительн" + (n != 1 ?"ых":"ое") + " нечетн" + (n != 1 ? "ых" : "ое") + ".");  
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
