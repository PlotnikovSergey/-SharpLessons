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
        public static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Задание 2. Реализуйте задачу 1 в виде статического класса StaticClass;\n а)  Класс должен  содержать статический  метод,  который принимает на вход массив и " +
                "решает задачу 1;\n б)  *Добавьте  статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;\n в)**Добавьте обработку ситуации " +
                "отсутствия файла на диске. \n");

            Array2.WriteToFile();
            Array2.Print1();
            Console.WriteLine("Массив записан в файл array2.txt на дискe C:\\Temp");
            Console.ReadKey();
            Array2.ReadFromFile();
            Console.WriteLine("Массив считан из файла array2.txt на дискe C:\\Temp");
            Array2.Print2();
            restart2();
        }

        class Array2
        {
            static int[] arrayTask2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            static string filename = @"C:\Temp\array2.txt";
            static int[] arrayTask2new;

            public static void WriteToFile()
            {
                FileStream fileStream = new FileStream(filename, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fileStream);
                for (int i = 0; i < arrayTask2.Length; i++)
                {
                    bw.Write(arrayTask2[i]);
                }
                bw.Close();
                fileStream.Close();
            }

            public static void ReadFromFile()
            {
                BinaryReader br = null;
                try {
                    FileStream fileStream = new FileStream(filename, FileMode.Open);
                    br = new BinaryReader(fileStream);
                    arrayTask2new = new int[fileStream.Length / sizeof(int)];
                    for (int i = 0; i < arrayTask2new.Length; i++)
                    {
                        arrayTask2new[i] = br.ReadInt32();
                    }
                    br.Close();
                    fileStream.Close();
                    }
                catch (FileNotFoundException)
                    {
                    Console.WriteLine("Файл не найден!");
                    Console.ReadKey();
                    }
            }

            public static void Print2()
            {
                string s = "";
                foreach (int v in arrayTask2new)
                {
                    s = s + v + " ";
                }
                Console.WriteLine(s);
            }

            public static void Print1()
            {
                string s = "";
                foreach (int v in arrayTask2)
                {
                    s = s + v + " ";
                }
                Console.WriteLine(s);
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
