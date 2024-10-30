using System.Data;

namespace cbt;

class Program
{
    // liczby pierwsze
    static void ZnajdzLiczbyPierwsze(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            bool pierwsza = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    pierwsza = false;
                    break;
                }
            }
            if (pierwsza)
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool CzyJestPierwsza(int n)
    {
        if (n <= 1) return false;
        for (int j = 2; j <= Math.Sqrt(n); j++)
        {
            if (n % j == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void NajblizszaLiczbaPierwsza(int n)
    {
        if (CzyJestPierwsza(n))
        {
            Console.WriteLine("Najbliższa liczba pierwsza to " + n);
            return;
        }

        int i = n - 1;
        int j = n + 1;

        while (true)
        {
            if (CzyJestPierwsza(i) && CzyJestPierwsza(j))
            {
                Console.WriteLine("Najbliższe liczby pierwsze to " + i + " i " + j);
                break;
            }
            if (CzyJestPierwsza(i))
            {
                Console.WriteLine("Najbliższa liczba pierwsza to " + i);
                break;
            }
            if (CzyJestPierwsza(j))
            {
                Console.WriteLine("Najbliższa liczba pierwsza to " + j);
                break;
            }
            i--;
            j++;
        }
    }



    //Ciągi iteracyjne + rekurencyjne
    static void CiagFibonacciegoIteracyjnie(int n)
    {
        int a = 0;
        int b = 1;
        for (int i = 1; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
            Console.WriteLine(a);
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void CiagFibonnaciegoRekurencyjnie(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }

    static int Ciag(int l)
    {
        int w = 1;
        if (l == 1)
        {
            w = 2;
            Console.WriteLine(w);
            return w;
        }
        else if (l % 2 == 0)
        {
            w = Ciag(l - 1) + 2;
            Console.WriteLine(w);
            return w;
        }
        else
        {
            w = Ciag(l - 1) * 2;
            Console.WriteLine(w);
            return w;
        }
    }

    // iteracyjnie
    static void ciagiter(int l)
    {
        int f0 = 1;
        int w = 1;
        for (int i = 1; i <= l; i++)
        {
            if (i == 1)
            {
                w = 2;
            }
            else if (i % 2 == 0)
            {
                w += 2;
            }
            else
            {
                w *= 2;
            }
            Console.WriteLine("W = " + w);
        }      
    }



    // pomyślenie = cbt


    //tablice 2D
    static int[,] GenerujTablice2D(int n, int m)
    {
        int[,] tablica = new int[n, m];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                tablica[i, j] = random.Next(10);
            }
        }
        return tablica;
    }

    static void WypiszTablice2D(int[,] tablica)
    {
        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            for (int j = 0; j < tablica.GetLength(1); j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] IloczynMacierzy(int[,] a, int[,] b)
    {
        int[,] wynik = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    wynik[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return wynik;
    }

    static void Main()
    {
        Console.WriteLine("Hello, World!");
        ZnajdzLiczbyPierwsze(100);
        CzyJestPierwsza(100);
        CiagFibonacciegoIteracyjnie(10);
        CiagFibonnaciegoRekurencyjnie(10);

        Console.WriteLine("________________________");
        ciagiter(11);
        Console.WriteLine("________________________");
        Ciag(11);
        Console.WriteLine("________________________");

        int[,] matrix = GenerujTablice2D(3, 3);
        WypiszTablice2D(matrix);

        int[,] matrix2 = GenerujTablice2D(3, 3);
        WypiszTablice2D(matrix2);

        int[,] wynik = IloczynMacierzy(matrix, matrix2);
        WypiszTablice2D(wynik);

        Console.WriteLine("--------------------------");
        NajblizszaLiczbaPierwsza(100);
    }
}
