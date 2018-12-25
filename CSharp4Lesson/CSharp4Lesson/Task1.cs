using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4Lesson
{
    partial class Program
    {
        
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Задание 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10000 до 10000 включительно." +
                "Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.В данной " +
                "задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. \n");

            Array1​ arrayTask1 = new Array1(20, -10000, 10000);
            Console.WriteLine(arrayTask1.ToString());
            arrayTask1.DivBy3();
            restart1();
        }
        class Array1
        {
            int[] arrayTask1;

            public Array1(int n, int min, int max)
            {
                arrayTask1 = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    arrayTask1[i] = rnd.Next(min, max);
                }
            }

            public override string ToString()
            {
                string s = "";
                foreach (int v in arrayTask1)
                {
                    s = s + v + " ";
                }
                return s;
            }

            public void DivBy3()
            {
                int m = 0;
                for (int i = 1; i < arrayTask1.Length; i++)
                    if (arrayTask1[i-1] % 3 == 0 ^ arrayTask1[i] % 3 == 0) {
                        m++;
                    }
                Console.WriteLine("Ответ " + m + " пар элементов массива, в которой хотя бы 1 элемент делится на 3.\n");
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
