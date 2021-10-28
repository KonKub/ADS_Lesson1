using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {

        public class TestCase
        {
            public int N { get; set; }
            public bool Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static void TestPrimeNum(TestCase testCase)
        {
            try
            {
                var actual = PrimeNum(testCase.N);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }

        static bool PrimeNum(int number)
        {
            int d = 0;

            for (int i = 2; i<number;i++)
            if (number % i == 0) d++;

            if (d==0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            /*
            int n = 0;
            Console.Write("Введите число: ");
            int.TryParse(Console.ReadLine(), out n);
            if (PrimeNum(n))
                Console.WriteLine("Простое");
            else
                Console.WriteLine("Не простое");
            */
            var testCase1 = new TestCase()
            {
                N = 3,
                Expected = true,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                N = 5,
                Expected = true,
                ExpectedException = null
            };

            var testCase3 = new TestCase()
            {
                N = 7,
                Expected = true,
                ExpectedException = null
            };

            var testCase4 = new TestCase()
            {
                N = 6,
                Expected = false,
                ExpectedException = null
            };
            var testCase5 = new TestCase()
            {
                N = 10,
                Expected = false,
                ExpectedException = null
            };
            var testCase6 = new TestCase()
            {
                N = 100,
                Expected = false,
                ExpectedException = null
            };

            TestPrimeNum(testCase1);
            TestPrimeNum(testCase2);
            TestPrimeNum(testCase3);
            TestPrimeNum(testCase4);
            TestPrimeNum(testCase5);
            TestPrimeNum(testCase6);

            Console.ReadKey();
        }
    }
}

