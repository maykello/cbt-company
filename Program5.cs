namespace zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------------- //
            Console.WriteLine("Podaj cyfry");
            string e = Console.ReadLine();
            string s = null;

            for (int i = 0; i < e.Length; i++)
            {
                //int d = (int.Parse(e[i].ToString())) * (int.Parse(e[i].ToString()));
                //int d = (e[i] - 48) * (e[i] - 48);
                int d = (e[i] - '0') * (e[i] - '0');
                s += d.ToString();
            }
            Console.WriteLine(s);
            // --------------- //
            
            Console.Write("a=");
            string a = Console.ReadLine();
            int a1 = int.Parse(a);
            Console.Write("b=");
            string b = Console.ReadLine();
            int b1 = int.Parse(b);
            Console.Write("c=");
            string c = Console.ReadLine();
            int c1 = int.Parse(c);

            if ((a1 * a1 + b1 * b1 == c1 * c1 || a1 * a1 + c1 * c1 == b1 * b1 || b1 * b1 + c1 * c1 == a1 * a1))
            {
                Console.WriteLine("Trojkąt prostokątny");
            }
            else
            {
                Console.WriteLine("Trójkąt nie jest prostokątny");
            }
        }
    }
}



