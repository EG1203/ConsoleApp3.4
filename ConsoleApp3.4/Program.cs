using System;

namespace ConsoleApp3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x");
                double x = double.Parse(Console.ReadLine());
                double s = 0;
                for (int i = 1, h = 1; i < n; i++, h += 2)
                {
                    long F = 1;
                    for (int j = n - 1; j >= 1; j--)
                    {
                        F *= j;
                    }

                    s += -(Math.Pow(2 * x, x)) + (Math.Pow(2 * x, 4)) - (Math.Pow(2 * x, 6)) / F;
                }
                Console.WriteLine("S={0;f2)", s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
