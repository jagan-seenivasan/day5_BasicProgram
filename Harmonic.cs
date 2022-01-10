using System;

namespace ConsoleApp1
{
    class Harmonic
    {
        public static void harmonicSeries()
        {
            int i, n;
            double s = 0.0;

            Console.Write("\n\n");
            Console.Write("harmonic series:\n");
            Console.Write("----------------------------------------------");


            Console.Write("Enter the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");

            if (n > 0)
            {
                for (i = 1; i <= n; i++)
                {
                    Console.Write("1/{0} + ", i);
                    s += 1 / (float)i;
                }
                Console.WriteLine("\nSum of  harmonic Series on {0} terms : {1} \n", n, s);
            }
            else
            {
                Console.WriteLine("enter a value larger than '0' (in positive) ");
            }

        }
    }
}