using System;

namespace CSharp3Lesson
{
    partial class Program
    {
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Задание 3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. " +
                "Написать программу, демонстрирующую все разработанные элементы класса. **Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение ArgumentException" +
                "Знаменатель не может быть равен 0; Добавить упрощение дробей.\n");

            Fractions fraction1 = new Fractions();
            Fractions fraction2 = new Fractions();
            fraction1.setNumerator(1);
            fraction1.setDenominator(2);
            fraction2.setNumerator(1);
            fraction2.setDenominator(2);
            Console.WriteLine("Первая дробь: " + fraction1.ToString());
            Console.WriteLine("Вторая дробь: " + fraction2.ToString()+ "\n");
 
            Fractions result = new Fractions();
            
            result = fraction1.Plus(fraction2);
            Console.WriteLine("Сумма: {0}", result.ToString());

            result = fraction1.Minus(fraction2);
            Console.WriteLine("Разность: {0}", result.ToString());

            result = fraction1.Multiply(fraction2);
            Console.WriteLine("Произведение: {0}", result.ToString());

            result = fraction1.Divide(fraction2);
            Console.WriteLine("Деление: {0}", result.ToString());

            restart3();
        }

        class Fractions
        {
            private int numerator;
            private int denominator;

            public void setNumerator(int value)
            {
                numerator = value;
            }

            public void setDenominator(int value)
            {
                if (value == 0) throw new ArgumentOutOfRangeException("Знаменатель не может быть равен 0!");
                denominator = value;
            }

            public int getNumerator()
            {
                return numerator;
            }

            public int getDenominator()
            {
                return denominator;
            }

            public Fractions Plus(Fractions fraction2)
            {
                Fractions fraction3 = new Fractions();
                fraction3.setDenominator(fraction2.getDenominator() * getDenominator());
                fraction3.setNumerator((fraction2.getNumerator() * getDenominator()) + (getNumerator() * fraction2.getDenominator()));
                return fraction3;
            }

            public Fractions Minus(Fractions fraction2)
            { 
                Fractions fraction3 = new Fractions();
                fraction3.setDenominator(fraction2.getDenominator() * getDenominator());
                fraction3.setNumerator((getNumerator() * fraction2.getDenominator()) - (fraction2.getNumerator() * getDenominator()));
                return fraction3;
            }

            public Fractions Multiply(Fractions fraction2)
            {
                Fractions fraction3 = new Fractions();
                fraction3.setDenominator(fraction2.getDenominator() * getDenominator());
                fraction3.setNumerator(fraction2.getNumerator() * getNumerator());
                return fraction3;
            }

            public Fractions Divide(Fractions fraction2)
            {
                Fractions fraction3 = new Fractions();
                fraction3.setDenominator(getDenominator() * fraction2.getNumerator());
                fraction3.setNumerator(getNumerator() * fraction2.getDenominator());
                return fraction3;
            }

            public string ToString()
            {
               return numerator + "/" + denominator;
            }
        }

         static void restart3()
        { 
           Console.WriteLine("\nНажмите кнопку \"Пробел\" для повтора этого решения или любую другую для возврата к выбору задания");
           ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Spacebar)
                {
                    Task3();
                }
                else return;
        }
        
    }
}