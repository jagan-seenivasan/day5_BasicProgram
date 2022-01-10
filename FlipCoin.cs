using System;


namespace ConsoleApp1
{
    class FlipCoin
    {
        public static void FlipTheCoin()
        {
            Console.WriteLine("pleasew enter the value for number of flips");

            int Head = 0;
            int Tail=0;
            int HeadCount = 0;
            int TailCount = 0;



            int flipCoin = Convert.ToInt32(Console.ReadLine());

            if (flipCoin>=0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    
                    if (number == 1)
                    {
                        Head = 1;
                        HeadCount += Head;
                    }
                    else if (number==0)
                    {
                        Tail = 1;
                        TailCount += Tail;
                    }

                    Console.WriteLine(number);
                }

                    Console.WriteLine("------");
                    Console.WriteLine(HeadCount);
                    Console.WriteLine(TailCount);

                
            }
            else
            {
                Console.WriteLine("please enter positive number");
            }
        }
    }
}
