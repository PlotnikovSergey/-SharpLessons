using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3Lesson
{
    partial class Program
    {
        static void Task2()
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
