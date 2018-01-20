using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix
{
    class Program
    {
        static int ReadInt() // Ввод целого числа
        {
            int num = 0;
            bool OK = false;
            do
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    OK = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Ожидалось целое число.");
                    OK = false;
                }
            } while (!OK);
            return num;
        }

        static double ReadDouble() // Ввод действительного числа
        {
            double num = 0;
            bool OK = false;
            do
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    OK = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Ожидалось число.");
                    OK = false;
                }
            } while (!OK);
            return num;
        }

        static double a1, a2, a3;

        static double Recursion(int K)
        {


            if (K == 1)
            {
                return a1;
            }

            if (K == 2)
            {
                return a2;
            }

            if (K == 3)
            {
                return a3;
            }

            return 3/2 * Recursion(K - 1) - 2/3 * Recursion(K - 2) - 1/3 * Recursion(K - 3);
        }


        static void Main(string[] args)
        {
            bool OK = false;
            int J = 0;
            Console.WriteLine("Введите a1:");
            a1 = ReadDouble();
            Console.WriteLine("Введите a2:");
            a2 = ReadDouble();
            Console.WriteLine("Введите a3:");
            a3 = ReadDouble();
            Console.WriteLine("Введите M:");
            int M = ReadInt();
            Console.WriteLine("Введите N:");
            int N = ReadInt();

            do
            {
                J++;
                if (Math.Abs(Recursion(J)) <= M) OK = true;
            } while (!OK);

            Console.WriteLine(Recursion(J));

            if (Math.Abs(Recursion(J)) == M) Console.WriteLine("Равенство выполняется.");
            else Console.WriteLine("Равенство не выполняется.");

            if (J > N) Console.WriteLine("J > N");
            else if (J < N) Console.WriteLine("J < N");
            else Console.WriteLine("J = N");

            Console.ReadLine();
        }
    }
}
