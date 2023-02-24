namespace Atilla_Rustamli_25_fevral_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("4 reqemli ededi yazin:");
            int n = int.Parse(Console.ReadLine());
            if (!(999 < n && n < 10000))
            {
                goto l1;
            }
            int x = 700008 + n * 10;
            Console.WriteLine(x);
        }
    }
}