namespace Atilla_Rustemli_25_fevral_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("5 reqemli ededi qeyd edin: ");
            int n = int.Parse(Console.ReadLine());
            if (!(9999 < n && n < 100000))
            {
                goto l1;
            }
            double a = (n * 18) / 100;
            double b = (n * 3) / 100;
            Console.WriteLine($"Ededin 18 faizi: {a}");
            Console.WriteLine($"Ededin 3 faizi: {b}");
        }
    }
}