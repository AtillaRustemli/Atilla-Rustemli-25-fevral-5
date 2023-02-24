namespace Atilla_Rustamli_25_fevral_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("3 reqemli ededi qeyd edin: ");

            int n = int.Parse(Console.ReadLine());

            if (!(99 < n && n < 1000))
            {
                goto l1;
            }
            double a = (n * 10) + 7;
            double b = (a * 7) / 100;
            Console.WriteLine($"Sonuna 7 reqemi elave etdikden sonra alinan eded: {a}");
            Console.WriteLine($"Alinan ededin 7 faizi{b}");
        }
    }
}