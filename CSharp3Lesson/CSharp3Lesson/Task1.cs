using System;

namespace CSharp3Lesson
{
    partial class Program
    {

        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Задание 1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры; " +
                "б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;\n");

            Console.WriteLine("Тестируем структуру:\n");
            TestStruct();
            Console.WriteLine("Тестируем класс:\n");
            TestClass();
        }

        static void TestStruct()
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        static void TestClass()

        {   // Описали ссылку на объект.
            ComplexClass complex1;
            // Создали объект и сохранили ссылку на него в complex1.
            complex1 = new ComplexClass(1, 1);
            // Описали объект и создали его.
            ComplexClass complex2 = new ComplexClass(2, 2);
            // С помощью свойства Im изменили внутреннее (приватное) поле im.
            complex2.Im = 3;
            // Создали ссылку на объект.
            ComplexClass result;
            // Так как в методе Plus создается новый объект,
            // в result сохраняем ссылку на вновь созданный объект.
            result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());

            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());

            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());

            restart();

        }

        struct Complex
        {
            public double im;
            public double re;
            // в C# в структурах могут храниться также действия над данными
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }
            // Пример произведения двух комплексных чисел
            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }
            // Добавили вычитание двух комплексных чисел
            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public string ToString()
            {
                string sign = im > 0 ? "+" : "";
                return re + sign + im + "i";
            }
        }
    

        class ComplexClass
        {
            // Поля приватные.
            private double im;
            // По умолчанию элементы приватные, поэтому private можно не писать.
            double re;
            // Конструктор без параметров.
            public ComplexClass()
            {
                im = 0;
                re = 0;
            }
            // Конструктор, в котором задаем поля.
            // Специально создадим параметр re, совпадающий с именем поля в классе.
            public ComplexClass(double _im, double re)
            {
                // Здесь имена не совпадают, и компилятор легко понимает, что чем является.
                im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.re = re;
            }
            public ComplexClass Plus(ComplexClass x2)
            {
                ComplexClass x3 = new ComplexClass();
                x3.im = x2.im + im;
                x3.re = x2.re + re;
                return x3;
            }

            public ComplexClass Minus(ComplexClass x2)
            {
                ComplexClass x3 = new ComplexClass();
                x3.im = im - x2.im;
                x3.re = re - x2.re;
                return x3;
            }

            public ComplexClass Multi(ComplexClass x)
            {
                ComplexClass y = new ComplexClass();
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            // Свойства - это механизм доступа к данным класса.
            public double Im
            {
                get { return im; }
                set
                {
                    // Для примера ограничимся только положительными числами.
                    if (value >= 0) im = value;
                }
            }
            // Специальный метод, который возвращает строковое представление данных.
            public string ToString()
            {
                string sign = im > 0 ? "+" : "";
                return re + sign + im + "i";
            }
        }

        static void restart()
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

