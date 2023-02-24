namespace Atilla_Rustamli_25_fevral_2
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
            Console.WriteLine($"{n}{n}");
        }
    }
}