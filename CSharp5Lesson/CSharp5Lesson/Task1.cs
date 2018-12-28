using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CSharp5Lesson
{
    partial class Program
    {
        public static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Задание 1. Написать статический метод void CreateCharsFile(string filename, int start, int finish), который создает файл содержащий символы из заданного диапазона" +
                "(от start до finish).Обработать корректно исключения связанные с невозможностью создания файла. \n");

            CharsToFile.InputData();
            CharsToFile.CreateCharsFile();
            restart1();
        }

        class CharsToFile
        {
            public static string directoryname = @"C:\Temp\";
            public static string fullname;
            public static string filename;
            public static int start;
            public static int finish;

            public static void InputData()
            {
                Console.WriteLine("Введите имя файла английскими буквами вместе с раширением (например: data.dat)");
                filename = Console.ReadLine();
                Regex regex = new Regex(@"[A-Za-z0-9]+\.[A-Za-z0-9]{1,3}$");
                if (regex.IsMatch(filename))
                {
                    fullname = directoryname + filename;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат имени файла! Повторите ввод.");
                    Console.ForegroundColor = ConsoleColor.White;
                    InputData();
                }

                Console.WriteLine("Введите код первого символа: ");
                regex = new Regex(@"[0-9]");
                start = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите код последнего символа: ");
                finish = int.Parse(Console.ReadLine());
            }
            
            public static void CreateCharsFile()
            {                
                try
                {
                    FileStream fileStream = new FileStream(fullname, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fileStream);
                    for (int i = start; i <= finish; i++)
                    {
                    sw.WriteLine(i +" " +(char)i);
                    }
                    sw.Close();
                    fileStream.Close();
                    Console.WriteLine("Последовательность символов записана в файл " + fullname + ".\n");
                }
                catch
                {
                    Console.WriteLine("Записать не удалось! Проверьте наличие директории!");
                }               
            }
        }

        static void restart1()
        {
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
