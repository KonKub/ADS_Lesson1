using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static int X = 0;            //заданный номер числа Фибоначчи (>=0)

        static int n = 0;
        static int F0 = 0, F1 = 1;
        static int F = 0;            //результат

        static void FibonacciRecursion()
        {
            if (n >= X - 1) return;
            else
            {
                F = F0 + F1;
                F0 = F1;
                F1 = F;

                n++;
                FibonacciRecursion();
            }
        }

        static void Fibonacci()
        {
            for (n=0; n < X - 1; n++)
            {
                F = F0 + F1;
                F0 = F1;
                F1 = F;
            }
        }

        static void Main(string[] args)
        {
            X = 5;

            if (X<0)
            {
                Console.WriteLine($"Неверный ввод: {X}");
                Console.ReadKey();
                return;
            }
            if (X == 0)
            {
                F = 0;
                Console.WriteLine($" {X} : {F}");
                Console.ReadKey();
                return;
            }
            if (X == 1)
            {
                F = 1;
                Console.WriteLine($" {X} : {F}");
                Console.ReadKey();
                return;
            }

            F0 = 0;
            F1 = 1;
            F = 0;
            FibonacciRecursion();
            Console.WriteLine($"Рекурсия. {X} : {F}");

            F0 = 0;
            F1 = 1;
            F = 0;
            Fibonacci();
            Console.WriteLine($"Без рекурсии {X} : {F}");

            Console.ReadKey();
        }
    }
}
