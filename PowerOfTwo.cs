using System;

namespace ConsoleApp1

{
    class PowerOfTwo
    {
        public static void Power()
        {
            int n;
            Console.WriteLine("Enter the Value: \n");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 31)
            {
                for (int i = 0; n <= 300; i += 1)
                {
                    n *= n;
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("enter the value under 31");
            }

        }
    }
}