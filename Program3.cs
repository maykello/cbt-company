using System;
using System.Numerics;

namespace Tortury
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 100;
            BigInteger balls = 1;
            for(int i=1; i<=N; i++) {
                balls *= i;
            }
            Console.WriteLine(balls);
            Console.WriteLine();
            int[] t6;
            int[] t1 = { 1,2 ,3 ,4 , 5, 6, 7, 8 };
            int[] t2 = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] t3 = new int[] { 2, 3, 5, 3 };
            int[] t4 = new int[4] { 2, 3, 5, 3 };

            Console.WriteLine(t2[2]);
            int[] t5 = new int[5];

            for(int i=0;i<t5.Length;i++)
            {
                t5[i] = 57 % (i+1);
            }
            for (int i = 0; i < t5.Length; i++)
            {
                Console.WriteLine(t5[i]);
            }

            t6 = new int[2];
            t6[0] = 69;
            t6[1] = 420;

            int[] t7 = t6;
            Console.WriteLine("t7[0]=" + t7[0]);
            int a = 8;
            int b = a;
            a = 12;
            Console.WriteLine("b=" + b);

            int[] t8 = new int[2];
            for(int i=0;i<t6.Length; i++) {
                t8[i] = t6[i];
            }
            t6[1] = 666;
            Console.WriteLine("t8[1]=" + t8[1]);
            Console.WriteLine("  ");

            double[] D1 = { 1.2, 3.4, 5.6, 7.8, 4.2, 1,2 };

            double[] D2 = D1[2..4];

            double[] D3 = D1[..5];
            double[] D4 = D1[2..];
            double[] D5 = D1[3..2 ^]; // do drugiego od końca
            for (int i = 0;  i< D2.Length; i++)
            {
                Console.WriteLine(D2[i] + " ");
            }
            for (int i = 0; i < D3.Length; i++)
            {
                Console.WriteLine(D3[i] + " ");
            }
            for (int i = 0; i < D4.Length; i++)
            {
                Console.WriteLine(D4[i] + " ");
            }

            int[,] X;
            int[][] Y;

            int[,] KMS = { { 1, 2, 3 }, { 4, 5, 6 } };
            for(int i=0; i< KMS.Length; i++) {
                for (int j = 0; j < KMS.Length; j++)
                {
                    Console.WriteLine(KMS[i][j]);
                }
            }

            string[][] invocations = new string[4][];
            invocations[0] = new string[] { "Litwo! Ojczyzno moja!", "Ty jesteś jak zdrowie.", "Ile cię trzeba cenić, ten tylko się dowie,", "Kto cię stracił." };
            invocations[1] = new string[] { "Dziś piękność twą w całej ozdobie widzę", "I opisuję, bo tęsknię po tobie.", "Panno święta, co Jasnej bronisz Częstochowy", "I w Ostrej świecisz Bramie!" };
            invocations[2] = new string[] { "Ty, co gród zamkowy Nowogródzki ochraniasz", "Zawierzając w Twą opiekę swój obronny los,", "Częstochowo! Tyś jest Matką Polaków", "I ich dzielną obroną!" };
            invocations[3] = new string[] { "Wysławiać Cię będę, o Matko przeczysta,", "Wysławiać Cię będę, bośś zawsze gotowa", "Do pomocy ludziom, gdy ich nękają wrogowie,", "I wzywają pomocy!" };
        }
    }
}
