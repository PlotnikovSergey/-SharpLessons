using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2Lesson
{
    partial class Program
    {
        static void Task4()
        {
            Console.Clear();
            Console.WriteLine("Задание 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, + " +
                "если не прошел + (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа " +
                "пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.");
            int attempts = 3;
            string login = "root";
            string password = "GeekBrains";
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("Введите логин:");
                String inputLogin = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                String inputPassword = Console.ReadLine();
                if (inputLogin == login & inputPassword == password)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Доступ разрешен.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                attempts--;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nНеверный логин или пароль. Доступ запрещен. ");
                if (attempts == 0)
                {
                    Console.WriteLine("Попыток не осталось! Нажмите любую кнопку для закрытия программы.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    //   Environment.Exit(0);  Закомментировал, чтобы не выходить из программы, а вернутся к проверке.
                    break;
                }
                Console.Write ("Осталось " + attempts + " попыт" + (attempts > 1?"ки":"ка"));
                Console.ForegroundColor = ConsoleColor.White;
            }
            while (attempts > 0);
            Console.WriteLine("Нажмите кнопку \"Пробел\" для повтора этого решения или любую другую для возврата к выбору задания");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                Task4();
            }
            else return;
        }
    }
}
