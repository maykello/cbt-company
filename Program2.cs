using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace programowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Podaj cyfry");
            string e = Console.ReadLine();
            string s = null;

            for (int i = e.Length-1; i >= 0; i--)
            {
                //int d = (int.Parse(e[i].ToString())) * (int.Parse(e[i].ToString()));
                double d = (char.GetNumericValue(e[i])) * (char.GetNumericValue(e[i]));
                //int d = (e[i] - 48) * (e[i] - 48);
                //int d = (e[i] - '0') * (e[i] - '0');
                s += d.ToString();
            }
            Console.WriteLine(s);
            */


            /*
            int ReverseDigit(int f)
            {
                string b = f.ToString();
                string s = null;
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    int d = (b[i] - '0') * (b[i] - '0');
                    s += d.ToString();
                }
                Console.Write(s);
                int result = int.Parse(s);
                return result;
            }
            Console.WriteLine("Podaj cyfry");
            string e = Console.ReadLine();
            int f = int.Parse(e);
            ReverseDigit(f);
            */

            /*
            Console.WriteLine("Podaj dlugosc tablicy");
            int n = int.Parse(Console.ReadLine());
            int[] fun(int n)
            {
                Random random = new Random();
                int[] tab = new int[n];
                for (int i=0; i<n; i++)
                {
                    tab[i] = random.Next(1, 100);
                }
                return tab;
            }

            int[] tab = fun(n);
            Console.WriteLine("Zawartosc tablicy:");
            for(int i =0; i<n; i++)
            {
                Console.Write(tab[i] + ", ");
            }
            */


            /*
            Console.WriteLine("Podaj dlugosc tablicy");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] fun(int n, int m)
            {
                Random random = new Random();
                int[,] tab = new int[n,m];
                for (int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                        tab[i,j] = random.Next(1, 100);
                }
                return tab;
            }

            int[,] tab = fun(n,m);
            Console.WriteLine("Zawartosc tablicy:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(tab[i,j] + ", ");
                Console.WriteLine();
            }
            */


            /*
            Console.WriteLine("Podaj wymiary tablicy 1");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wymiary tablicy 2");
            int n1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());

            int[,] fun(int n, int m)
            {
                Random random = new Random();
                int[,] tab = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        tab[i, j] = random.Next(1, 10);
                }
                return tab;
            }

            int[,] tab = fun(n, m);
            int[,] tab2 = fun(n1, m1);
            int[,] tab3 = new int[n1, m1];

            int[,] dodawanie(int[,] tab, int[,] tab2)
            {
                if(n==n1 && m == m1)
                {
                    //int[,] tab3 = new int[n, m];
                    for(int  i = 0; i < n; i++)
                    {
                        for(int j=0; j < m; j++)
                        {
                            tab3[i, j] = tab[i, j] + tab2[i, j];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Macierzy musza miec ten sam rozmiar zeby je dodac do siebie");
                }
                return tab3;
            }

            tab3 = dodawanie(tab, tab2);

            // mnozenie macierzy
            int[,] tab4 = new int[n, m1];
            int s = 0;
            int[,] mnozenie(int[,] tab, int[,] tab2)
            {
                if (m==n1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            s = 0;
                            for (int k = 0; k < m1; k++)
                            {
                                s += tab[i, k] * tab2[k, j];
                            }
                            tab4[i, j] = s;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nie da sie pomnozyc macierzy");
                }
                return tab4;
            }
            /*
            tab4 = mnozenie(tab, tab2);

            Console.WriteLine("Zawartosc tablicy 1:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(tab[i, j] + ", ");
                Console.WriteLine();
            }
            Console.WriteLine("Zawartosc tablicy 2:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(tab2[i, j] + ", ");
                Console.WriteLine();
            }

            Console.WriteLine("Zawartosc tablicy po dodawaniu:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(tab3[i, j] + ", ");
                Console.WriteLine();
            }

            Console.WriteLine("Zawartosc tablicy po mnozeniu:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(tab4[i, j] + ", ");
                Console.WriteLine();
            }
            */

            Console.WriteLine("Podaj wymiary tablicy 1");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wymiary tablicy 2");
            int n1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());

            int[][] fun(int n, int m)
            {
                Random random = new Random();
                int[][] tab = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    tab[i] = new int[m];
                    for (int j = 0; j < m; j++)
                        tab[i][j] = random.Next(1, 10);
                }
                return tab;
            }

            int[][] tab = fun(n, m);
            int[][] tab2 = fun(n1, m1);
            int[][] tab3 = new int[n1][];

            int[][] dodawanie_S(int[][] tab, int[][] tab2)
            {
                if (n == n1 && m == m1)
                {
                    //int[,] tab3 = new int[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        tab3[i] = new int[m];
                        for (int j = 0; j < m; j++)
                        {
                            tab3[i][j] = tab[i][j] + tab2[i][j];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Macierzy musza miec ten sam rozmiar zeby je dodac do siebie");
                }
                return tab3;
            }

            tab3 = dodawanie_S(tab, tab2);

            // mnozenie macierzy
            int[][] tab4 = new int[n][];
            int s = 0;
            int[][] mnozenie_S(int[][] tab, int[][] tab2)
            {
                if (m == n1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        tab4[i] = new int[m1];
                        for (int j = 0; j < m; j++)
                        {
                            s = 0;
                            for (int k = 0; k < m1; k++)
                            {
                                s += tab[i][k] * tab2[k][j];
                            }
                            tab4[i][j] = s;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nie da sie pomnozyc macierzy");
                }
                return tab4;
            }

            tab4 = mnozenie_S(tab, tab2);

            Console.WriteLine("Zawartosc tablicy 1:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(tab[i][j] + ", ");
                Console.WriteLine();
            }
            Console.WriteLine("Zawartosc tablicy 2:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(tab2[i][j] + ", ");
                Console.WriteLine();
            }

            Console.WriteLine("Zawartosc tablicy po dodawaniu:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(tab3[i][j] + ", ");
                Console.WriteLine();
            }

            if (n1 == m)
            {
                Console.WriteLine("Zawartosc tablicy po mnozeniu:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        Console.Write(tab4[i][j] + ", ");
                    Console.WriteLine();
                }
            }


            ////////////////////////////////////////////////////////////////////////////////
            n = 200; m = 200;
            int[,] mat1 = new int[n, m];
            int[,] mat2 = new int[n, m];
            int[][] mat3 = new int[n][];
            int[][] mat4 = new int[n][];

            Stopwatch sw = new Stopwatch();

            sw.Start();
            //dodawanie(mat3, mat4);
            Console.WriteLine("Czas:" + sw.Elapsed);
            sw.Stop();

            sw.Start();
            //mnozenie(mat3, mat4);
            Console.WriteLine("Czas:" + sw.Elapsed);
            sw.Stop();

            sw.Start();
            dodawanie_S(mat3, mat4);
            Console.WriteLine("Czas:" +  sw.Elapsed);
            sw.Stop();

            sw.Start();
            mnozenie_S(mat3, mat4);
            Console.WriteLine("Czas:" + sw.Elapsed);
            sw.Stop();






        }
    }
}
