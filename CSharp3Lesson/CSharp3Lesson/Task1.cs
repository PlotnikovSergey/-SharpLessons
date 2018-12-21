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
            Console.WriteLine("Первое число: " + complex1.re + "+" + complex1.im + "i");
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;
            Console.WriteLine("Второе число: " + complex2.re + "+" + complex2.im + "i");
            Console.WriteLine("\n");

            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Сложение: " + result.ToString());

            result = complex1.Minus(complex2);
            Console.WriteLine("Вычитание: " + result.ToString());

            result = complex1.Multi(complex2);
            Console.WriteLine("Умножение: " + result.ToString());
            Console.WriteLine("Нажмите любую клавишу для продолжения.\n\n");
            Console.ReadKey();     
        }

        struct Complex
        {
            public double im;
            public double re;

            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }

            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            public string ToString()
            {
                string sign = im > 0 ? "+" : "";
                return re + sign + im + "i";
            }
        }

        static void TestClass()
        {   
            ComplexClass complex1;
            complex1 = new ComplexClass(1, 1);
            Console.WriteLine("Первое число: " + complex1.ToString());

            ComplexClass complex2 = new ComplexClass(2, 2);        
            complex2.Im = 3;
            Console.WriteLine("Второе число: " + complex2.ToString());
            Console.WriteLine("\n");

            ComplexClass result;
            
            result = complex1.Plus(complex2);
            Console.WriteLine("Сложение: " + result.ToString());

            result = complex1.Minus(complex2);
            Console.WriteLine("Вычитание: " + result.ToString());

            result = complex1.Multi(complex2);
            Console.WriteLine("Умножение: " + result.ToString());

            restart1();
        } 

        class ComplexClass
        {
            private double im;
            double re;
            
            public ComplexClass()
            {
                im = 0;
                re = 0;
            }
            
            public ComplexClass(double _im, double re)
            {
                im = _im;
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
         
            public double Im
            {
                get { return im; }
                set
                {
                    if (value >= 0) im = value;
                }
            }
           
            public string ToString()
            {
                string sign = im > 0 ? "+" : "";
                return re + sign + im + "i";
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

