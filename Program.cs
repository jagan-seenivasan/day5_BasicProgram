using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            userInput uc1 = new userInput();
            userInput.PrintTheName();
         // FlipCoin Uc2 = new FlipCoin();
         // FlipCoin.FlipTheCoin();
         // LeapYear Uc3 = new LeapYear();
         // LeapYear.checkLeapYear();
        //  PrimeFactor Uc4 = new PrimeFactor();
         // PrimeFactor.ThePrime();
         // Harmonic Uc5 = new Harmonic();
         // Harmonic.harmonicSeries();
         OddOrEven Uc6 = new OddOrEven();
            OddOrEven.CheckEvenOddNumber();
            LargestAmongTheeNumbers Uc7 = new LargestAmongTheeNumbers();
            LargestAmongTheeNumbers.CheckLargestAmongTheeNumbers();
            QuatientAndRemainder Uc8= new QuatientAndRemainder();
            QuatientAndRemainder.FindQuatientAndRemainder();

        }
    }
}