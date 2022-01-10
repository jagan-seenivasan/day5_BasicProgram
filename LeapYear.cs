using System;

namespace ConsoleApp1
{
    class LeapYear
    {
        public static void checkLeapYear()
        {
            int chk_Leapyear;
            Console.WriteLine("Check whether a given year is leap year or not:");
            Console.WriteLine("Input an year : ");
            chk_Leapyear = Convert.ToInt32(Console.ReadLine());

            if ((chk_Leapyear % 400) == 0)
                Console.WriteLine("{0} is a leap year.", chk_Leapyear);
            else if ((chk_Leapyear % 100) == 0)
                Console.WriteLine("{0} is not a leap year.", chk_Leapyear);
            else if ((chk_Leapyear % 4) == 0)
                Console.WriteLine("{0} is a leap year.", chk_Leapyear);
            else
                Console.WriteLine("{0} is not a leap year.", chk_Leapyear);
        }
    }
}