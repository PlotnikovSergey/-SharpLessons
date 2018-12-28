using System;
using System.Text.RegularExpressions;

namespace CSharp5Lesson
{
    partial class Program
    {
        public static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Задание 2. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы " +
                "латинского алфавита или цифры, при этом цифра не может быть первой: \nа) без использования регулярных выражений; \nб) **с использованием регулярных выражений. \n");
            LoginCheck();
            LoginCheck2();
            restart2();
        }
        #region
        public static void LoginCheck()
        {
            bool check = true;
            do
            {
                Console.WriteLine("Вариант а)\n");
                Console.WriteLine("Введите логин\n");
                string inputLogin = Console.ReadLine();

                char[] arrayLogin;
                arrayLogin = inputLogin.ToCharArray();
                if (arrayLogin.Length < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Слишком короткий. Нужно не менее 2-ух символов!");
                    Console.ForegroundColor = ConsoleColor.White;
                    check = false;
                }
                else if (arrayLogin.Length > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Слишком длинный. Нужно не более 10-и символов!");
                    Console.ForegroundColor = ConsoleColor.White;
                    check = false;
                }
                else if (char.IsDigit(arrayLogin[0]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Первый символ - цифра! Исправьте.");
                    Console.ForegroundColor = ConsoleColor.White;
                    check = false;
                }
                    else
                        { 
                        foreach (char v in arrayLogin)
                            {
                            int s = v;
                            //Console.WriteLine("Проверяем символ: " + v + " его код: " + s); 
                                if (s > 122 | s < 48 | s > 90 & s < 97 | s > 57 & s < 65)
                                {
                                Console.ForegroundColor = ConsoleColor.Red;
                                string x = new string(arrayLogin);
                                Console.WriteLine("Логин некорректный! Символ " + v + " не подходит!");
                                Console.ForegroundColor = ConsoleColor.White;
                                check = false;
                                break;
                                }
                                check = true;
                            }
                        }               
            }
            while (check == false);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Логин хороший! ");
                Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        public static void LoginCheck2()
        {
            Console.WriteLine("Вариант б)\n");
            Console.WriteLine("Введите логин\n");
            string inputLogin = Console.ReadLine();
            Regex reg = new Regex(@"^[\D][A-Za-z0-9]{1,9}$");
            if (reg.IsMatch(inputLogin))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Логин корректный!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Логин некорректный!");
                Console.ForegroundColor = ConsoleColor.White;
            }
    }

        static void restart2()
        {
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
