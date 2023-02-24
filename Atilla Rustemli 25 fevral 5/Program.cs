namespace Atilla_Rustemli_25_fevral_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.Write("4 reqemli ededi qeyd edin: ");
            int n = int.Parse(Console.ReadLine());
            if (!(999 < n && n < 10000))
            {
                goto l1;
            }
            int x = 4000000 + (n * 100) + 44;
            double y = (x * 44) / 100;
            Console.WriteLine($"Edednin evveline 4 sonuna 44 artirdiqdan sonra alinan eded: {x}");
            Console.WriteLine($"Alinan ededin 44 faizi: {y}");
        }
    }
}