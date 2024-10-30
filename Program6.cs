namespace P3_gr1b
{
    internal class Program
    {
        enum dni { Poniedziałek, Wtorek, Środa, Czwartek, Piątek, Sobota, Niedziela };
        static void Main(string[] args)
        {
            Enum dzisiaj = dni.Środa;
            string input = Console.ReadLine();
            Console.WriteLine("I typed: " + input);

            int cbt = 0;
            do
            {
                Console.WriteLine("Jasny gwint");
                cbt++;
            }
            while (cbt < 5);

            string[] kolory = { "rozowy", "sledziowy", "cockowy" };
            foreach(string kolor in kolory)
            {
                Console.WriteLine(kolor);
            }
        }          
    }
}