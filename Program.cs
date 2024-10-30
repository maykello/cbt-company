using System;

namespace programowanie
{
    internal class Program
    {
        static int Silnia(int l)
        {
            if (l <= 1)
            {
                return 1;
            }
            return l * Silnia(l - 1);
        }
     
        static int Fibonacci(int l)
        {
            int w = 1;
            if (l == 0)
            {
                w = 0;
                return w;
            }
            else if (l == 1)
            {
                w = 1;
                return w;
            }
            else
            {
                w = Fibonacci(l - 1) + Fibonacci(l - 2);
                return w;
            }
        }
 

        static void Fibo(int l, Funkcje funkcje)
        {
            if(funkcje == Funkcje.rekurencyjnie)
            {
                static int Fibonacci(int l)
                {
                    int w = 1;
                    if (l == 0)
                    {
                        w = 0;
                        return w;
                    }
                    else if (l == 1)
                    {
                        w = 1;
                        return w;
                    }
                    else
                    {
                        w = Fibonacci(l - 1) + Fibonacci(l - 2);
                        return w;
                    }
                }
            }
            else if(funkcje == Funkcje.iteracyjnie)
            {
                int f0 = 0;
                int f1 = 1;
                int w = 0;

                if (l == 0)
                {
                    w = 0;
                }
                else if (l == 1)
                {
                    w = 1;
                }
                else if (l > 1)
                {
                    for (int i = 2; i <= l; i++)
                    {
                        w = f0 + f1;
                        f0 = f1;
                        f1 = w;
                    }
                }
            }
        }

        static int Ciag(int l)
        {
            int w = 1;
            if(l==1)
            {
                w = 2;
                return w;
            }
            else if(l % 2 == 0)
            {
                w = Ciag(l - 1) + 2;
                return w;
            }
            else
            {
                w = Ciag(l - 1) * 2;
                return w;
            }
        }
		
		

        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę");
            int l = int.Parse(Console.ReadLine());
            int w = 1;

            if (l >= 1)
            {
                for (int i = 1; i < l + 1; i++)
                {
                    Console.Write(w + ", ");
                    w *= i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Silnia z " + l + " = " + w);
            Console.WriteLine("Silnia rekurencyjnie z " + l + " = " + Silnia(l));

            // Ciąg fibonacciego
            Console.WriteLine("------------------");

            int f0 = 0;
            int f1 = 1;
            w = 0;

            if (l == 0)
            {
                w = 0;
            }
            else if (l == 1)
            {
                w = 1;
            }
            else if (l > 1)
            {
                for (int i = 2; i <= l; i++)
                {
                    w = f0 + f1;
                    f0 = f1;
                    f1 = w;
                }
            }
            Console.WriteLine("Ciąg Fibonacciego iteracyjnie: " + w);
            Console.WriteLine("Ciąg Fibonacciego rekruencyjnie: " + Fibonacci(l));

            // Ciąg
            Console.WriteLine("------------------");
            f0 = 1;
            w = 1;
            for (int i = 1; i <= l; i++)
            {
                if (i == 1)
                {
                    w = 2;
                }
                else if (i % 2 == 1)
                {
                    w *= 2;
                }
                else
                {
                    w += 2;
                }
            }
            Console.WriteLine("Ciąg iteracyjnie: " + w);
            Console.WriteLine("Ciąg rekurencyjnie: " + Ciag(l));

            Console.WriteLine("------------------------");
            Fibo(l, Funkcje.rekurencyjnie);
            Fibo(l, Funkcje.iteracyjnie);
        }

        enum Funkcje
        {
            iteracyjnie,
            rekurencyjnie
        }
    }
}